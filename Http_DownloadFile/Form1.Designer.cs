
namespace Http_DownloadFile
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
            this.textBox_InputUrl = new System.Windows.Forms.TextBox();
            this.label_Url = new System.Windows.Forms.Label();
            this.button_Download = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_resume = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.label_exeption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_InputUrl
            // 
            this.textBox_InputUrl.Location = new System.Drawing.Point(62, 44);
            this.textBox_InputUrl.Name = "textBox_InputUrl";
            this.textBox_InputUrl.Size = new System.Drawing.Size(551, 20);
            this.textBox_InputUrl.TabIndex = 0;
            this.textBox_InputUrl.TextChanged += new System.EventHandler(this.textBox_InputUrl_TextChanged);
            // 
            // label_Url
            // 
            this.label_Url.AutoSize = true;
            this.label_Url.Location = new System.Drawing.Point(12, 47);
            this.label_Url.Name = "label_Url";
            this.label_Url.Size = new System.Drawing.Size(32, 13);
            this.label_Url.TabIndex = 1;
            this.label_Url.Text = "URL:";
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(619, 40);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 23);
            this.button_Download.TabIndex = 2;
            this.button_Download.Text = "Download";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(619, 69);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(75, 23);
            this.button_pause.TabIndex = 3;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_resume
            // 
            this.button_resume.Location = new System.Drawing.Point(619, 98);
            this.button_resume.Name = "button_resume";
            this.button_resume.Size = new System.Drawing.Size(75, 23);
            this.button_resume.TabIndex = 4;
            this.button_resume.Text = "Resume";
            this.button_resume.UseVisualStyleBackColor = true;
            this.button_resume.Click += new System.EventHandler(this.button_resume_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 96);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(53, 13);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "STATUS:";
            // 
            // label_exeption
            // 
            this.label_exeption.AutoSize = true;
            this.label_exeption.ForeColor = System.Drawing.Color.Red;
            this.label_exeption.Location = new System.Drawing.Point(12, 9);
            this.label_exeption.Name = "label_exeption";
            this.label_exeption.Size = new System.Drawing.Size(64, 13);
            this.label_exeption.TabIndex = 6;
            this.label_exeption.Text = "EXEPTION:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 135);
            this.Controls.Add(this.label_exeption);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_resume);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.label_Url);
            this.Controls.Add(this.textBox_InputUrl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_InputUrl;
        private System.Windows.Forms.Label label_Url;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_resume;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_exeption;
    }
}

