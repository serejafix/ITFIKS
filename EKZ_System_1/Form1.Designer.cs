
namespace EKZ_System_1
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_EnterWords = new System.Windows.Forms.Label();
            this.txb_EnterWords = new System.Windows.Forms.TextBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Start.Location = new System.Drawing.Point(397, 176);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(12, 94);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(460, 60);
            this.progressBar.TabIndex = 2;
            // 
            // lbl_EnterWords
            // 
            this.lbl_EnterWords.AutoSize = true;
            this.lbl_EnterWords.ForeColor = System.Drawing.Color.Black;
            this.lbl_EnterWords.Location = new System.Drawing.Point(9, 36);
            this.lbl_EnterWords.Name = "lbl_EnterWords";
            this.lbl_EnterWords.Size = new System.Drawing.Size(130, 13);
            this.lbl_EnterWords.TabIndex = 5;
            this.lbl_EnterWords.Text = "Enter Words for Search ->";
            // 
            // txb_EnterWords
            // 
            this.txb_EnterWords.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txb_EnterWords.Location = new System.Drawing.Point(145, 33);
            this.txb_EnterWords.Name = "txb_EnterWords";
            this.txb_EnterWords.ReadOnly = true;
            this.txb_EnterWords.Size = new System.Drawing.Size(327, 20);
            this.txb_EnterWords.TabIndex = 6;
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.ForeColor = System.Drawing.Color.Black;
            this.lbl_path.Location = new System.Drawing.Point(13, 69);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(29, 13);
            this.lbl_path.TabIndex = 7;
            this.lbl_path.Text = "Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.txb_EnterWords);
            this.Controls.Add(this.lbl_EnterWords);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_Start);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_EnterWords;
        private System.Windows.Forms.TextBox txb_EnterWords;
        private System.Windows.Forms.Label lbl_path;
    }
}

