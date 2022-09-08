
namespace CW_Barber_DatebaseFirst
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
            this.dgv_Query = new System.Windows.Forms.DataGridView();
            this.button_AllBarber = new System.Windows.Forms.Button();
            this.btn_FioOnly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Query
            // 
            this.dgv_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Query.Location = new System.Drawing.Point(13, 141);
            this.dgv_Query.Name = "dgv_Query";
            this.dgv_Query.Size = new System.Drawing.Size(754, 286);
            this.dgv_Query.TabIndex = 0;
            // 
            // button_AllBarber
            // 
            this.button_AllBarber.Location = new System.Drawing.Point(13, 75);
            this.button_AllBarber.Name = "button_AllBarber";
            this.button_AllBarber.Size = new System.Drawing.Size(75, 23);
            this.button_AllBarber.TabIndex = 1;
            this.button_AllBarber.Text = "Execute";
            this.button_AllBarber.UseVisualStyleBackColor = true;
            this.button_AllBarber.Click += new System.EventHandler(this.button_AllBarber_Click);
            // 
            // btn_FioOnly
            // 
            this.btn_FioOnly.Location = new System.Drawing.Point(111, 74);
            this.btn_FioOnly.Name = "btn_FioOnly";
            this.btn_FioOnly.Size = new System.Drawing.Size(75, 23);
            this.btn_FioOnly.TabIndex = 2;
            this.btn_FioOnly.Text = "Execute";
            this.btn_FioOnly.UseVisualStyleBackColor = true;
            this.btn_FioOnly.Click += new System.EventHandler(this.btn_FioOnly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_FioOnly);
            this.Controls.Add(this.button_AllBarber);
            this.Controls.Add(this.dgv_Query);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Query;
        private System.Windows.Forms.Button button_AllBarber;
        private System.Windows.Forms.Button btn_FioOnly;
    }
}

