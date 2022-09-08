
namespace CW_BarberShop
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_disconect = new System.Windows.Forms.Button();
            this.labelConnection = new System.Windows.Forms.Label();
            this.btn_AllBarbers = new System.Windows.Forms.Button();
            this.labelAllBarbers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(13, 13);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_disconect
            // 
            this.btn_disconect.Location = new System.Drawing.Point(94, 13);
            this.btn_disconect.Name = "btn_disconect";
            this.btn_disconect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconect.TabIndex = 2;
            this.btn_disconect.Text = "Disconect";
            this.btn_disconect.UseVisualStyleBackColor = true;
            this.btn_disconect.Click += new System.EventHandler(this.btn_disconect_Click);
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Location = new System.Drawing.Point(13, 43);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(0, 13);
            this.labelConnection.TabIndex = 3;
            // 
            // btn_AllBarbers
            // 
            this.btn_AllBarbers.Location = new System.Drawing.Point(244, 29);
            this.btn_AllBarbers.Name = "btn_AllBarbers";
            this.btn_AllBarbers.Size = new System.Drawing.Size(75, 23);
            this.btn_AllBarbers.TabIndex = 4;
            this.btn_AllBarbers.Text = "Вывести!";
            this.btn_AllBarbers.UseVisualStyleBackColor = true;
            this.btn_AllBarbers.Click += new System.EventHandler(this.btn_AllBarbers_Click);
            // 
            // labelAllBarbers
            // 
            this.labelAllBarbers.AutoSize = true;
            this.labelAllBarbers.Location = new System.Drawing.Point(241, 13);
            this.labelAllBarbers.Name = "labelAllBarbers";
            this.labelAllBarbers.Size = new System.Drawing.Size(128, 13);
            this.labelAllBarbers.TabIndex = 5;
            this.labelAllBarbers.Text = "Вывести всех барберов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAllBarbers);
            this.Controls.Add(this.btn_AllBarbers);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.btn_disconect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_disconect;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Button btn_AllBarbers;
        private System.Windows.Forms.Label labelAllBarbers;
    }
}

