namespace WF_SecureChatWithBlockchain
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
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            Logs = new ListBox();
            ClientsLogs = new ListBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            btn_Connection = new ReaLTaiizor.Controls.NightButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 57);
            panel1.TabIndex = 1;
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
            nightControlBox1.Location = new Point(743, 0);
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 2;
            label1.Text = "СДОЗС - 1 СЕРВЕР";
            // 
            // Logs
            // 
            Logs.FormattingEnabled = true;
            Logs.ItemHeight = 15;
            Logs.Location = new Point(234, 63);
            Logs.Name = "Logs";
            Logs.Size = new Size(641, 439);
            Logs.TabIndex = 14;
            // 
            // ClientsLogs
            // 
            ClientsLogs.FormattingEnabled = true;
            ClientsLogs.ItemHeight = 15;
            ClientsLogs.Location = new Point(12, 182);
            ClientsLogs.Name = "ClientsLogs";
            ClientsLogs.Size = new Size(216, 319);
            ClientsLogs.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 92);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 11;
            label2.Text = "Порт:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 9;
            label3.Text = "Хост:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 8;
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
            btn_Connection.Location = new Point(12, 129);
            btn_Connection.MinimumSize = new Size(144, 47);
            btn_Connection.Name = "btn_Connection";
            btn_Connection.NormalBackColor = Color.MediumTurquoise;
            btn_Connection.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btn_Connection.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            btn_Connection.PressedForeColor = Color.White;
            btn_Connection.Radius = 1;
            btn_Connection.Size = new Size(216, 47);
            btn_Connection.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_Connection.TabIndex = 29;
            btn_Connection.Text = "Включить сервер";
            btn_Connection.Click += btn_Connection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 510);
            Controls.Add(btn_Connection);
            Controls.Add(Logs);
            Controls.Add(ClientsLogs);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private ListBox Logs;
        private ListBox ClientsLogs;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private ReaLTaiizor.Controls.NightButton btn_Connection;
    }
}
