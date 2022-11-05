
namespace Client_Currency
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Cure = new System.Windows.Forms.Label();
            this.label_Curency = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.comboBoxSecond = new System.Windows.Forms.ComboBox();
            this.comboBoxFirst = new System.Windows.Forms.ComboBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label_Stopwatch = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pasw = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_pasw);
            this.groupBox1.Controls.Add(this.label_password);
            this.groupBox1.Controls.Add(this.textBox_login);
            this.groupBox1.Controls.Add(this.label_login);
            this.groupBox1.Controls.Add(this.label_Time);
            this.groupBox1.Controls.Add(this.label_Stopwatch);
            this.groupBox1.Controls.Add(this.label_Cure);
            this.groupBox1.Controls.Add(this.label_Curency);
            this.groupBox1.Controls.Add(this.button_Send);
            this.groupBox1.Controls.Add(this.comboBoxSecond);
            this.groupBox1.Controls.Add(this.comboBoxFirst);
            this.groupBox1.Controls.Add(this.textBox_Port);
            this.groupBox1.Controls.Add(this.textBox_Ip);
            this.groupBox1.Controls.Add(this.label_IP);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label_Cure
            // 
            this.label_Cure.AutoSize = true;
            this.label_Cure.BackColor = System.Drawing.Color.LightCoral;
            this.label_Cure.Location = new System.Drawing.Point(61, 116);
            this.label_Cure.Name = "label_Cure";
            this.label_Cure.Size = new System.Drawing.Size(0, 13);
            this.label_Cure.TabIndex = 8;
            // 
            // label_Curency
            // 
            this.label_Curency.AutoSize = true;
            this.label_Curency.Location = new System.Drawing.Point(6, 119);
            this.label_Curency.Name = "label_Curency";
            this.label_Curency.Size = new System.Drawing.Size(49, 13);
            this.label_Curency.TabIndex = 7;
            this.label_Curency.Text = "Curency:";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(234, 82);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 6;
            this.button_Send.Text = "GetCurrency";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // comboBoxSecond
            // 
            this.comboBoxSecond.FormattingEnabled = true;
            this.comboBoxSecond.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "PLN"});
            this.comboBoxSecond.Location = new System.Drawing.Point(127, 84);
            this.comboBoxSecond.Name = "comboBoxSecond";
            this.comboBoxSecond.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSecond.TabIndex = 5;
            // 
            // comboBoxFirst
            // 
            this.comboBoxFirst.FormattingEnabled = true;
            this.comboBoxFirst.Items.AddRange(new object[] {
            "USD",
            "PLN",
            "EUR"});
            this.comboBoxFirst.Location = new System.Drawing.Point(9, 84);
            this.comboBoxFirst.Name = "comboBoxFirst";
            this.comboBoxFirst.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFirst.TabIndex = 4;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(180, 44);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(52, 20);
            this.textBox_Port.TabIndex = 3;
            this.textBox_Port.Text = "1000";
            // 
            // textBox_Ip
            // 
            this.textBox_Ip.Location = new System.Drawing.Point(74, 44);
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ip.TabIndex = 2;
            this.textBox_Ip.Text = "127.0.0.1";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(6, 47);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(55, 13);
            this.label_IP.TabIndex = 1;
            this.label_IP.Text = "IP Adress:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(234, 43);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label_Stopwatch
            // 
            this.label_Stopwatch.AutoSize = true;
            this.label_Stopwatch.BackColor = System.Drawing.Color.Red;
            this.label_Stopwatch.Location = new System.Drawing.Point(236, 116);
            this.label_Stopwatch.Name = "label_Stopwatch";
            this.label_Stopwatch.Size = new System.Drawing.Size(0, 13);
            this.label_Stopwatch.TabIndex = 9;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.Red;
            this.label_Time.Location = new System.Drawing.Point(185, 116);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(42, 13);
            this.label_Time.TabIndex = 10;
            this.label_Time.Text = "Time->:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(25, 21);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(36, 13);
            this.label_login.TabIndex = 11;
            this.label_login.Text = "Login:";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(74, 21);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 12;
            this.textBox_login.Text = "login";
            // 
            // textBox_pasw
            // 
            this.textBox_pasw.Location = new System.Drawing.Point(237, 20);
            this.textBox_pasw.Name = "textBox_pasw";
            this.textBox_pasw.Size = new System.Drawing.Size(70, 20);
            this.textBox_pasw.TabIndex = 14;
            this.textBox_pasw.Text = "password";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(180, 24);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 170);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Cure;
        private System.Windows.Forms.Label label_Curency;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.ComboBox comboBoxSecond;
        private System.Windows.Forms.ComboBox comboBoxFirst;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_Stopwatch;
        private System.Windows.Forms.TextBox textBox_pasw;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_login;
    }
}

