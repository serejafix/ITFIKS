
namespace DZ_Api1
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
            this.btn_Tusk1 = new System.Windows.Forms.Button();
            this.btn_Tusk2 = new System.Windows.Forms.Button();
            this.btn_tusk22 = new System.Windows.Forms.Button();
            this.txb_newTitle = new System.Windows.Forms.TextBox();
            this.lbl_newTitle = new System.Windows.Forms.Label();
            this.btn_Tusk3 = new System.Windows.Forms.Button();
            this.btn_Tusk32 = new System.Windows.Forms.Button();
            this.btn_Form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Tusk1
            // 
            this.btn_Tusk1.Location = new System.Drawing.Point(13, 26);
            this.btn_Tusk1.Name = "btn_Tusk1";
            this.btn_Tusk1.Size = new System.Drawing.Size(75, 23);
            this.btn_Tusk1.TabIndex = 0;
            this.btn_Tusk1.Text = "Задание-1";
            this.btn_Tusk1.UseVisualStyleBackColor = true;
            this.btn_Tusk1.Click += new System.EventHandler(this.btn_Tusk1_Click);
            // 
            // btn_Tusk2
            // 
            this.btn_Tusk2.Location = new System.Drawing.Point(94, 26);
            this.btn_Tusk2.Name = "btn_Tusk2";
            this.btn_Tusk2.Size = new System.Drawing.Size(84, 23);
            this.btn_Tusk2.TabIndex = 1;
            this.btn_Tusk2.Text = "Задание-2.1";
            this.btn_Tusk2.UseVisualStyleBackColor = true;
            this.btn_Tusk2.Click += new System.EventHandler(this.btn_Tusk2_Click);
            // 
            // btn_tusk22
            // 
            this.btn_tusk22.Location = new System.Drawing.Point(184, 26);
            this.btn_tusk22.Name = "btn_tusk22";
            this.btn_tusk22.Size = new System.Drawing.Size(84, 23);
            this.btn_tusk22.TabIndex = 2;
            this.btn_tusk22.Text = "Задание-2.2";
            this.btn_tusk22.UseVisualStyleBackColor = true;
            this.btn_tusk22.Click += new System.EventHandler(this.btn_tusk22_Click);
            // 
            // txb_newTitle
            // 
            this.txb_newTitle.Location = new System.Drawing.Point(184, 68);
            this.txb_newTitle.Name = "txb_newTitle";
            this.txb_newTitle.Size = new System.Drawing.Size(100, 20);
            this.txb_newTitle.TabIndex = 3;
            // 
            // lbl_newTitle
            // 
            this.lbl_newTitle.AutoSize = true;
            this.lbl_newTitle.Location = new System.Drawing.Point(165, 52);
            this.lbl_newTitle.Name = "lbl_newTitle";
            this.lbl_newTitle.Size = new System.Drawing.Size(140, 13);
            this.lbl_newTitle.TabIndex = 4;
            this.lbl_newTitle.Text = "Введите новый заголовок";
            // 
            // btn_Tusk3
            // 
            this.btn_Tusk3.Location = new System.Drawing.Point(274, 26);
            this.btn_Tusk3.Name = "btn_Tusk3";
            this.btn_Tusk3.Size = new System.Drawing.Size(84, 23);
            this.btn_Tusk3.TabIndex = 5;
            this.btn_Tusk3.Text = "Задание-3";
            this.btn_Tusk3.UseVisualStyleBackColor = true;
            this.btn_Tusk3.Click += new System.EventHandler(this.btn_Tusk3_Click);
            // 
            // btn_Tusk32
            // 
            this.btn_Tusk32.Location = new System.Drawing.Point(364, 26);
            this.btn_Tusk32.Name = "btn_Tusk32";
            this.btn_Tusk32.Size = new System.Drawing.Size(84, 23);
            this.btn_Tusk32.TabIndex = 6;
            this.btn_Tusk32.Text = "Задание-3.1";
            this.btn_Tusk32.UseVisualStyleBackColor = true;
            this.btn_Tusk32.Click += new System.EventHandler(this.btn_Tusk32_Click);
            // 
            // btn_Form2
            // 
            this.btn_Form2.Location = new System.Drawing.Point(13, 114);
            this.btn_Form2.Name = "btn_Form2";
            this.btn_Form2.Size = new System.Drawing.Size(84, 23);
            this.btn_Form2.TabIndex = 7;
            this.btn_Form2.Text = "Form2";
            this.btn_Form2.UseVisualStyleBackColor = true;
            this.btn_Form2.Click += new System.EventHandler(this.btn_Form2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.btn_Form2);
            this.Controls.Add(this.btn_Tusk32);
            this.Controls.Add(this.btn_Tusk3);
            this.Controls.Add(this.lbl_newTitle);
            this.Controls.Add(this.txb_newTitle);
            this.Controls.Add(this.btn_tusk22);
            this.Controls.Add(this.btn_Tusk2);
            this.Controls.Add(this.btn_Tusk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tusk1;
        private System.Windows.Forms.Button btn_Tusk2;
        private System.Windows.Forms.Button btn_tusk22;
        private System.Windows.Forms.TextBox txb_newTitle;
        private System.Windows.Forms.Label lbl_newTitle;
        private System.Windows.Forms.Button btn_Tusk3;
        private System.Windows.Forms.Button btn_Tusk32;
        private System.Windows.Forms.Button btn_Form2;
    }
}

