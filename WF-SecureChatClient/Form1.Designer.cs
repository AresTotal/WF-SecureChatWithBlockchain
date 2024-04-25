namespace WF_SecureChatClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btn_Ham = new PictureBox();
            btnDashboard = new Button();
            sidebar = new FlowLayoutPanel();
            btnSettings = new Button();
            btnAbout = new Button();
            btnExit = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            dashboard = new Panel();
            label11 = new Label();
            btn_Submit = new ReaLTaiizor.Controls.NightButton();
            label9 = new Label();
            Logs = new ListBox();
            messageText = new TextBox();
            settings = new Panel();
            btn_Generation = new ReaLTaiizor.Controls.NightButton();
            btn_Connection = new ReaLTaiizor.Controls.NightButton();
            label8 = new Label();
            IPtextBox = new TextBox();
            label2 = new Label();
            PortTextBox = new TextBox();
            label3 = new Label();
            label6 = new Label();
            OKtextBox = new TextBox();
            SKtextBox = new TextBox();
            label4 = new Label();
            NonceTextBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            PKtextBox = new TextBox();
            about = new Panel();
            richTextBox1 = new RichTextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Ham).BeginInit();
            sidebar.SuspendLayout();
            dashboard.SuspendLayout();
            settings.SuspendLayout();
            about.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Ham);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 57);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(751, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 15);
            label1.Name = "label1";
            label1.Size = new Size(228, 32);
            label1.TabIndex = 2;
            label1.Text = "СДОЗС - 1 КЛИЕНТ";
            // 
            // btn_Ham
            // 
            btn_Ham.Image = (Image)resources.GetObject("btn_Ham.Image");
            btn_Ham.InitialImage = (Image)resources.GetObject("btn_Ham.InitialImage");
            btn_Ham.Location = new Point(12, 12);
            btn_Ham.Name = "btn_Ham";
            btn_Ham.Size = new Size(35, 35);
            btn_Ham.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Ham.TabIndex = 1;
            btn_Ham.TabStop = false;
            btn_Ham.Click += btn_Ham_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = SystemColors.ControlLightLight;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.RightToLeft = RightToLeft.No;
            btnDashboard.Size = new Size(323, 71);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Дашборд";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(btnSettings);
            sidebar.Controls.Add(btnAbout);
            sidebar.Controls.Add(btnExit);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 57);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(319, 557);
            sidebar.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.BackgroundImageLayout = ImageLayout.Zoom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = SystemColors.ControlLightLight;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 80);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(15, 0, 0, 0);
            btnSettings.RightToLeft = RightToLeft.No;
            btnSettings.Size = new Size(323, 71);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Настройки";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.Transparent;
            btnAbout.BackgroundImageLayout = ImageLayout.Zoom;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbout.ForeColor = SystemColors.ControlLightLight;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(3, 157);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(15, 0, 0, 0);
            btnAbout.RightToLeft = RightToLeft.No;
            btnAbout.Size = new Size(323, 71);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "Справка";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(3, 234);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(15, 0, 0, 0);
            btnExit.RightToLeft = RightToLeft.No;
            btnExit.Size = new Size(323, 71);
            btnExit.TabIndex = 3;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // dashboard
            // 
            dashboard.BorderStyle = BorderStyle.FixedSingle;
            dashboard.Controls.Add(label11);
            dashboard.Controls.Add(btn_Submit);
            dashboard.Controls.Add(label9);
            dashboard.Controls.Add(Logs);
            dashboard.Controls.Add(messageText);
            dashboard.Location = new Point(72, 60);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(478, 545);
            dashboard.TabIndex = 26;
            dashboard.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(15, 410);
            label11.Name = "label11";
            label11.Size = new Size(167, 21);
            label11.TabIndex = 27;
            label11.Text = "ВАШЕ СООБЩЕНИЕ :";
            // 
            // btn_Submit
            // 
            btn_Submit.BackColor = Color.Transparent;
            btn_Submit.DialogResult = DialogResult.None;
            btn_Submit.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Submit.ForeColor = Color.DimGray;
            btn_Submit.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btn_Submit.HoverForeColor = Color.White;
            btn_Submit.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btn_Submit.Location = new Point(14, 489);
            btn_Submit.MinimumSize = new Size(144, 47);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.NormalBackColor = Color.MediumTurquoise;
            btn_Submit.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btn_Submit.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btn_Submit.PressedForeColor = Color.White;
            btn_Submit.Radius = 20;
            btn_Submit.Size = new Size(239, 47);
            btn_Submit.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_Submit.TabIndex = 27;
            btn_Submit.Text = "Отправить сообщение";
            btn_Submit.Click += btn_Submit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 12);
            label9.Name = "label9";
            label9.Size = new Size(325, 21);
            label9.TabIndex = 24;
            label9.Text = "ЗАЩИЩЁННЫЙ ОБМЕН СООБЩЕНИЯМИ";
            // 
            // Logs
            // 
            Logs.FormattingEnabled = true;
            Logs.ItemHeight = 15;
            Logs.Location = new Point(14, 53);
            Logs.Name = "Logs";
            Logs.Size = new Size(447, 334);
            Logs.TabIndex = 10;
            // 
            // messageText
            // 
            messageText.Location = new Point(15, 435);
            messageText.Name = "messageText";
            messageText.Size = new Size(446, 23);
            messageText.TabIndex = 11;
            messageText.KeyDown += messageText_KeyDown;
            // 
            // settings
            // 
            settings.BorderStyle = BorderStyle.FixedSingle;
            settings.Controls.Add(btn_Generation);
            settings.Controls.Add(btn_Connection);
            settings.Controls.Add(label8);
            settings.Controls.Add(IPtextBox);
            settings.Controls.Add(label2);
            settings.Controls.Add(PortTextBox);
            settings.Controls.Add(label3);
            settings.Controls.Add(label6);
            settings.Controls.Add(OKtextBox);
            settings.Controls.Add(SKtextBox);
            settings.Controls.Add(label4);
            settings.Controls.Add(NonceTextBox);
            settings.Controls.Add(label5);
            settings.Controls.Add(label7);
            settings.Controls.Add(PKtextBox);
            settings.Location = new Point(556, 60);
            settings.Name = "settings";
            settings.Size = new Size(327, 405);
            settings.TabIndex = 27;
            settings.Visible = false;
            // 
            // btn_Generation
            // 
            btn_Generation.BackColor = Color.Transparent;
            btn_Generation.DialogResult = DialogResult.None;
            btn_Generation.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Generation.ForeColor = Color.DimGray;
            btn_Generation.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btn_Generation.HoverForeColor = Color.White;
            btn_Generation.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btn_Generation.Location = new Point(17, 202);
            btn_Generation.MinimumSize = new Size(144, 47);
            btn_Generation.Name = "btn_Generation";
            btn_Generation.NormalBackColor = Color.MediumTurquoise;
            btn_Generation.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btn_Generation.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btn_Generation.PressedForeColor = Color.White;
            btn_Generation.Radius = 1;
            btn_Generation.Size = new Size(285, 47);
            btn_Generation.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_Generation.TabIndex = 29;
            btn_Generation.Text = "Сгенерировать";
            btn_Generation.Click += btn_Generation_Click;
            // 
            // btn_Connection
            // 
            btn_Connection.BackColor = Color.Transparent;
            btn_Connection.DialogResult = DialogResult.None;
            btn_Connection.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Connection.ForeColor = Color.DimGray;
            btn_Connection.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            btn_Connection.HoverForeColor = Color.White;
            btn_Connection.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            btn_Connection.Location = new Point(17, 100);
            btn_Connection.MinimumSize = new Size(144, 47);
            btn_Connection.Name = "btn_Connection";
            btn_Connection.NormalBackColor = Color.MediumTurquoise;
            btn_Connection.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btn_Connection.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btn_Connection.PressedForeColor = Color.White;
            btn_Connection.Radius = 1;
            btn_Connection.Size = new Size(284, 47);
            btn_Connection.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_Connection.TabIndex = 28;
            btn_Connection.Text = "Подключение";
            btn_Connection.Click += btn_Connection_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 12);
            label8.Name = "label8";
            label8.Size = new Size(150, 21);
            label8.TabIndex = 23;
            label8.Text = "НАСТРОЙКИ СЕТИ";
            // 
            // IPtextBox
            // 
            IPtextBox.Location = new Point(68, 42);
            IPtextBox.Name = "IPtextBox";
            IPtextBox.Size = new Size(233, 23);
            IPtextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 42);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 6;
            label2.Text = "Хост:";
            // 
            // PortTextBox
            // 
            PortTextBox.Location = new Point(68, 71);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(233, 23);
            PortTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 71);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 8;
            label3.Text = "Порт:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(105, 151);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 21;
            label6.Text = "Общий ключ";
            // 
            // OKtextBox
            // 
            OKtextBox.Location = new Point(16, 276);
            OKtextBox.Name = "OKtextBox";
            OKtextBox.Size = new Size(285, 23);
            OKtextBox.TabIndex = 14;
            OKtextBox.TextChanged += OKtextBox_TextChanged;
            // 
            // SKtextBox
            // 
            SKtextBox.Location = new Point(16, 175);
            SKtextBox.Name = "SKtextBox";
            SKtextBox.Size = new Size(285, 23);
            SKtextBox.TabIndex = 20;
            SKtextBox.TextChanged += SKtextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(87, 252);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 15;
            label4.Text = "Публичный ключ";
            // 
            // NonceTextBox
            // 
            NonceTextBox.Location = new Point(87, 362);
            NonceTextBox.Name = "NonceTextBox";
            NonceTextBox.Size = new Size(214, 23);
            NonceTextBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(87, 302);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 16;
            label5.Text = "Приватный ключ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 359);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 18;
            label7.Text = "Nonce";
            // 
            // PKtextBox
            // 
            PKtextBox.Location = new Point(16, 326);
            PKtextBox.Name = "PKtextBox";
            PKtextBox.Size = new Size(285, 23);
            PKtextBox.TabIndex = 17;
            PKtextBox.TextChanged += PKtextBox_TextChanged;
            // 
            // about
            // 
            about.BorderStyle = BorderStyle.FixedSingle;
            about.Controls.Add(richTextBox1);
            about.Controls.Add(label10);
            about.Location = new Point(556, 471);
            about.Name = "about";
            about.Size = new Size(327, 134);
            about.TabIndex = 28;
            about.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(17, 39);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(285, 86);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "Проект КЗ Система Децентрализованного Обмена Защищёнными Сообщениями\n\nСделал: Шаймиев Аскар из 21ОИБ-1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(16, 11);
            label10.Name = "label10";
            label10.Size = new Size(238, 21);
            label10.TabIndex = 25;
            label10.Text = "СПРАВОЧНАЯ ИНФОРМАЦИЯ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 614);
            Controls.Add(sidebar);
            Controls.Add(about);
            Controls.Add(settings);
            Controls.Add(dashboard);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Ham).EndInit();
            sidebar.ResumeLayout(false);
            dashboard.ResumeLayout(false);
            dashboard.PerformLayout();
            settings.ResumeLayout(false);
            settings.PerformLayout();
            about.ResumeLayout(false);
            about.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btn_Ham;
        private Label label1;
        private Button btnDashboard;
        private FlowLayoutPanel sidebar;
        private Button btnSettings;
        private Button btnAbout;
        private Button btnExit;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel dashboard;
        private Label label9;
        private ListBox Logs;
        private TextBox messageText;
        private ReaLTaiizor.Controls.NightButton btn_Submit;
        private Panel settings;
        private Label label8;
        private TextBox IPtextBox;
        private Label label2;
        private TextBox PortTextBox;
        private Label label3;
        private Label label6;
        private TextBox OKtextBox;
        private TextBox SKtextBox;
        private Label label4;
        private TextBox NonceTextBox;
        private Label label5;
        private Label label7;
        private TextBox PKtextBox;
        private Panel about;
        private RichTextBox richTextBox1;
        private Label label10;
        private ReaLTaiizor.Controls.NightButton btn_Generation;
        private ReaLTaiizor.Controls.NightButton btn_Connection;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label11;
    }
}
