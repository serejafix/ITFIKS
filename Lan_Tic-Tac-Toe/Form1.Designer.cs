
namespace Lan_Tic_Tac_Toe
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
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_HostName = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_Ip);
            this.groupBox1.Location = new System.Drawing.Point(10, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Location = new System.Drawing.Point(7, 37);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(23, 13);
            this.lbl_Ip.TabIndex = 0;
            this.lbl_Ip.Text = "IP: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(278, 37);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_HostName
            // 
            this.btn_HostName.Location = new System.Drawing.Point(10, 117);
            this.btn_HostName.Name = "btn_HostName";
            this.btn_HostName.Size = new System.Drawing.Size(360, 32);
            this.btn_HostName.TabIndex = 1;
            this.btn_HostName.Text = "Host Game";
            this.btn_HostName.UseVisualStyleBackColor = true;
            this.btn_HostName.Click += new System.EventHandler(this.btn_HostName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 156);
            this.Controls.Add(this.btn_HostName);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.Button btn_HostName;
    }
}

