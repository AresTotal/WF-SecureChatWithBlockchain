using System.Net.Sockets;
using System.Net;
using System.Text;

namespace WF_SecureChatWithBlockchain
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async Task AsyncServer()
        {
            await Task.Run(() => Server());
        }

        #region CreateServer

        private static List<Socket> activeConnections = new List<Socket>();

        private static object lockObject = new object();

        Thread clientThread;

        private void Server()
        {
            string ip = ""; // IP-адрес сервера

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ip = textBox1.Text;
            }
            else
            {
                ip = "127.0.0.1";
                textBox1.Text = ip;
            }

            int port; // Порт сервера
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                port = int.Parse(textBox2.Text);
            }
            else
            {
                port = 8080;
                textBox2.Text = port.ToString();
            }

            var tcpListener = new TcpListener(IPAddress.Parse(ip), port);

            try
            {
                tcpListener.Start();
                Logs.Items.Add("Сервер запущен.");

                while (true)
                {
                    var clientSocket = tcpListener.AcceptSocket();
                    ClientsLogs.Items.Add(clientSocket.RemoteEndPoint.ToString());
                    lock (lockObject)
                    {
                        activeConnections.Add(clientSocket); // Добавление клиента в список
                    }

                    clientThread = new Thread(() => HandleClient(clientSocket));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Ошибка: " + ex.Message);
            }
            finally
            {
                tcpListener.Stop();
            }
        }
        private void HandleClient(Socket clientSocket)
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = clientSocket.Receive(buffer);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Logs.Items.Add(message);

                    lock (lockObject)
                    {
                        foreach (var connection in activeConnections)
                        {
                            if (connection != clientSocket && connection.Connected)
                            {
                                connection.Send(Encoding.UTF8.GetBytes(message));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.Items.Add("Ошибка обработки клиента: " + ex.Message);
            }
            finally
            {
                lock (lockObject)
                {
                    activeConnections.Remove(clientSocket);
                    clientSocket.Close();
                }
            }
        }
        #endregion

        private async void btn_Connection_Click(object sender, EventArgs e)
        {
            await AsyncServer();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientThread.Abort();
        }
    }
}
