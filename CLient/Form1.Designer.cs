
namespace CLient
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
            this.groupBox_Connect = new System.Windows.Forms.GroupBox();
            this.label_ListStreets = new System.Windows.Forms.Label();
            this.listBox_ListStreets = new System.Windows.Forms.ListBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button__Send = new System.Windows.Forms.Button();
            this.label_Index = new System.Windows.Forms.Label();
            this.textBox_Index = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_Ip = new System.Windows.Forms.Label();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.groupBox_Connect.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Connect
            // 
            this.groupBox_Connect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Connect.Controls.Add(this.label_ListStreets);
            this.groupBox_Connect.Controls.Add(this.listBox_ListStreets);
            this.groupBox_Connect.Controls.Add(this.textBox_Port);
            this.groupBox_Connect.Controls.Add(this.button__Send);
            this.groupBox_Connect.Controls.Add(this.label_Index);
            this.groupBox_Connect.Controls.Add(this.textBox_Index);
            this.groupBox_Connect.Controls.Add(this.button_Connect);
            this.groupBox_Connect.Controls.Add(this.label_Ip);
            this.groupBox_Connect.Controls.Add(this.textBox_Ip);
            this.groupBox_Connect.Location = new System.Drawing.Point(13, 13);
            this.groupBox_Connect.Name = "groupBox_Connect";
            this.groupBox_Connect.Size = new System.Drawing.Size(308, 435);
            this.groupBox_Connect.TabIndex = 0;
            this.groupBox_Connect.TabStop = false;
            this.groupBox_Connect.Text = "Connect";
            // 
            // label_ListStreets
            // 
            this.label_ListStreets.AutoSize = true;
            this.label_ListStreets.Location = new System.Drawing.Point(9, 104);
            this.label_ListStreets.Name = "label_ListStreets";
            this.label_ListStreets.Size = new System.Drawing.Size(56, 13);
            this.label_ListStreets.TabIndex = 8;
            this.label_ListStreets.Text = "ListStreets";
            // 
            // listBox_ListStreets
            // 
            this.listBox_ListStreets.FormattingEnabled = true;
            this.listBox_ListStreets.Location = new System.Drawing.Point(6, 123);
            this.listBox_ListStreets.Name = "listBox_ListStreets";
            this.listBox_ListStreets.Size = new System.Drawing.Size(295, 225);
            this.listBox_ListStreets.TabIndex = 7;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(172, 37);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(40, 20);
            this.textBox_Port.TabIndex = 6;
            this.textBox_Port.Text = "8888";
            // 
            // button__Send
            // 
            this.button__Send.Location = new System.Drawing.Point(226, 66);
            this.button__Send.Name = "button__Send";
            this.button__Send.Size = new System.Drawing.Size(75, 23);
            this.button__Send.TabIndex = 5;
            this.button__Send.Text = "Send";
            this.button__Send.UseVisualStyleBackColor = true;
            this.button__Send.Click += new System.EventHandler(this.button__Send_Click);
            // 
            // label_Index
            // 
            this.label_Index.AutoSize = true;
            this.label_Index.Location = new System.Drawing.Point(6, 71);
            this.label_Index.Name = "label_Index";
            this.label_Index.Size = new System.Drawing.Size(36, 13);
            this.label_Index.TabIndex = 4;
            this.label_Index.Text = "Index:";
            // 
            // textBox_Index
            // 
            this.textBox_Index.Location = new System.Drawing.Point(91, 71);
            this.textBox_Index.Name = "textBox_Index";
            this.textBox_Index.Size = new System.Drawing.Size(120, 20);
            this.textBox_Index.TabIndex = 3;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(226, 37);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_Ip
            // 
            this.label_Ip.AutoSize = true;
            this.label_Ip.Location = new System.Drawing.Point(6, 40);
            this.label_Ip.Name = "label_Ip";
            this.label_Ip.Size = new System.Drawing.Size(20, 13);
            this.label_Ip.TabIndex = 1;
            this.label_Ip.Text = "IP:";
            // 
            // textBox_Ip
            // 
            this.textBox_Ip.Location = new System.Drawing.Point(91, 37);
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(75, 20);
            this.textBox_Ip.TabIndex = 0;
            this.textBox_Ip.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 452);
            this.Controls.Add(this.groupBox_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Connect.ResumeLayout(false);
            this.groupBox_Connect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Connect;
        private System.Windows.Forms.Button button__Send;
        private System.Windows.Forms.Label label_Index;
        private System.Windows.Forms.TextBox textBox_Index;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_Ip;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label_ListStreets;
        private System.Windows.Forms.ListBox listBox_ListStreets;
    }
}

