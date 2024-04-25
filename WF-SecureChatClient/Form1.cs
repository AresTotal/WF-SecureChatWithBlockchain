using Sodium;
using System.IO;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;

namespace WF_SecureChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x201)
            {
                base.Capture = false;
                message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            }
            base.WndProc(ref message);
        }

        Chain _chain = new Chain();

        /// <summary>
        /// Переменные для алгоритма Curve25519
        /// </summary>
        static byte[]? publicKey; // Публичный ключ
        static byte[]? privateKey; // Приватный ключ
        static byte[]? nonce; // Уникальное случайное значение
        static byte[]? sharedKey; // Общий ключ

        NetworkStream stream; // Поток какой-то

        #region GenerateKeys
        private void Form1_Load(object sender, EventArgs e)
        {
            publicKey = GenerateKeyPair().PublicKey;
            privateKey = GenerateKeyPair().PrivateKey;
        }

        static KeyPair GenerateKeyPair()
        {
            KeyPair keyPair = PublicKeyBox.GenerateKeyPair();

            // Возврат приватного и публичного ключа в формате байтов
            return keyPair;
        }
        #endregion

        #region SidebarLogic

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 69)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 319)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btn_Ham_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool dashboardVisible = false;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!dashboardVisible)
            {
                dashboard.Visible = true;
                dashboardVisible = true;
            }
            else
            {
                dashboard.Visible = false;
                dashboardVisible = false;
            }
        }

        bool settingsVisible = false;
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!settingsVisible)
            {
                settings.Visible = true;
                settingsVisible = true;
            }
            else
            {
                settings.Visible = false;
                settingsVisible = false;
            }
        }

        bool aboutVisible = false;
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (!aboutVisible)
            {
                about.Visible = true;
                aboutVisible = true;
            }
            else
            {
                about.Visible = false;
                aboutVisible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string message = messageText.Text;

                Logs.Items.Add($"Вы: {message}");

                string encryptedMessage = Encrypt(message, sharedKey);

                _chain.Add(encryptedMessage);

                NonceTextBox.Text = ConvertByteToString(nonce);

                string nonceBase64 = Convert.ToBase64String(nonce);

                byte[] data = Encoding.UTF8.GetBytes(encryptedMessage + "|" + nonceBase64);

                stream.Write(data, 0, data.Length);

                //stream.Close();
                //client.Close();
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Ошибка: " + ex.Message);
            }
        }
        private void btn_Connection_Click(object sender, EventArgs e)
        {
            string ip = ""; // IP-адрес сервера

            if (!string.IsNullOrWhiteSpace(IPtextBox.Text))
            {
                ip = IPtextBox.Text;
            }
            else
            {
                ip = "127.0.0.1";
                IPtextBox.Text = ip;
            }

            int port; // Порт сервера
            if (!string.IsNullOrWhiteSpace(PortTextBox.Text))
            {
                port = int.Parse(PortTextBox.Text);
            }
            else
            {
                port = 8080;
                PortTextBox.Text = port.ToString();
            }

            //Публичный ключ
            OKtextBox.Text = ConvertByteToString(publicKey);

            //Приватный ключ
            PKtextBox.Text = ConvertByteToString(privateKey);

            // Создание TCP клиента
            TcpClient client = new TcpClient(ip, port);

            Logs.Items.Add("Подключено к серверу.");

            stream = client.GetStream();

            try
            {
                var receiveThread = new System.Threading.Thread(() =>
                {
                    while (true)
                    {
                        byte[] data = new byte[256];
                        int bytes = stream.Read(data, 0, data.Length);
                        string responseData = Encoding.UTF8.GetString(data, 0, bytes);
                        string[] parts = responseData.Split('|');
                        string encryptedMessage = parts[0];
                        string nonceBase64 = parts[1];
                        nonce = Convert.FromBase64String(nonceBase64);
                        NonceTextBox.Text = nonceBase64;
                        string decryptedText = Decrypt(encryptedMessage, sharedKey, nonce);
                        Logs.Items.Add("Сообщение от товарища: " + decryptedText);
                    }
                });
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Ошибка: " + ex.Message);
            }
        }

        #region ConvertingBytesAndString
        private static string ConvertByteToString(byte[] data)
        {
            return Convert.ToBase64String(data);
        }
        private static byte[] ConvertStringToByte(string data)
        {
            return Convert.FromBase64String(data);
        }
        #endregion

        #region Encrypt/Decrypt
        static string Encrypt(string message, byte[] sharedKey)
        {
            nonce = SecretBox.GenerateNonce();
            byte[] messageBytes = System.Text.Encoding.UTF8.GetBytes(message);
            byte[] encryptedMessage = SecretBox.Create(messageBytes, nonce, sharedKey);
            string encryptedMessageBase64 = Convert.ToBase64String(encryptedMessage);

            return encryptedMessageBase64;
        }

        static string Decrypt(string encryptedMessage, byte[] sharedKey, byte[] nonce)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedMessage);
                byte[] decryptedBytes = SecretBox.Open(encryptedBytes, nonce, sharedKey);
                string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                return decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при расшифровке сообщения: " + ex.Message);
                return null;
            }
        }
        #endregion

        private void OKtextBox_TextChanged(object sender, EventArgs e)
        {
            publicKey = ConvertStringToByte(OKtextBox.Text);
        }

        private void PKtextBox_TextChanged(object sender, EventArgs e)
        {
            privateKey = ConvertStringToByte(PKtextBox.Text);
        }
        private void SKtextBox_TextChanged(object sender, EventArgs e)
        {
            sharedKey = ConvertStringToByte(SKtextBox.Text);
        }

        private void btn_Generation_Click(object sender, EventArgs e)
        {
            //sharedKey = ScalarMult.Mult(privateKey, publicKey);

            sharedKey = ConvertStringToByte("qcfnHrAY8s2iOFt90zDKtSJbmzR0PvJn5FejIQUb7yQ=");

            SKtextBox.Text = Convert.ToBase64String(sharedKey);
        }

        private void messageText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Submit_Click(sender, e);
            }
        }
    }
}
