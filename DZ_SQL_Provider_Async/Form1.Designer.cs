
namespace DZ_SQL_Provider_Async
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
            this.btn_getFactory = new System.Windows.Forms.Button();
            this.cmb_provider = new System.Windows.Forms.ComboBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txb_nameUpdate = new System.Windows.Forms.TextBox();
            this.btn_updateSync = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.AsyncEnable = new System.Windows.Forms.CheckBox();
            this.btnAsync = new System.Windows.Forms.Button();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.btn_UpdateAsync = new System.Windows.Forms.Button();
            this.txb_UpdateColor = new System.Windows.Forms.TextBox();
            this.txb_UpdateColories = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.num_WhereId = new System.Windows.Forms.NumericUpDown();
            this.lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_WhereId)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getFactory
            // 
            this.btn_getFactory.Location = new System.Drawing.Point(13, 13);
            this.btn_getFactory.Name = "btn_getFactory";
            this.btn_getFactory.Size = new System.Drawing.Size(75, 23);
            this.btn_getFactory.TabIndex = 0;
            this.btn_getFactory.Text = "Получить!";
            this.btn_getFactory.UseVisualStyleBackColor = true;
            this.btn_getFactory.Click += new System.EventHandler(this.btn_getFactory_Click);
            // 
            // cmb_provider
            // 
            this.cmb_provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_provider.FormattingEnabled = true;
            this.cmb_provider.Location = new System.Drawing.Point(106, 15);
            this.cmb_provider.Name = "cmb_provider";
            this.cmb_provider.Size = new System.Drawing.Size(562, 21);
            this.cmb_provider.TabIndex = 1;
            this.cmb_provider.SelectedIndexChanged += new System.EventHandler(this.cmb_provider_SelectedIndexChanged_1);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(12, 75);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(76, 23);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(106, 179);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(682, 238);
            this.dataGridView.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "select * from Veg_and_Fruits";
            // 
            // txb_nameUpdate
            // 
            this.txb_nameUpdate.Location = new System.Drawing.Point(234, 124);
            this.txb_nameUpdate.Name = "txb_nameUpdate";
            this.txb_nameUpdate.Size = new System.Drawing.Size(111, 20);
            this.txb_nameUpdate.TabIndex = 6;
            // 
            // btn_updateSync
            // 
            this.btn_updateSync.Location = new System.Drawing.Point(12, 121);
            this.btn_updateSync.Name = "btn_updateSync";
            this.btn_updateSync.Size = new System.Drawing.Size(88, 23);
            this.btn_updateSync.TabIndex = 5;
            this.btn_updateSync.Text = "UpdateSync";
            this.btn_updateSync.UseVisualStyleBackColor = true;
            this.btn_updateSync.Click += new System.EventHandler(this.btn_updateSync_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(13, 44);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(88, 23);
            this.Connect.TabIndex = 7;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // AsyncEnable
            // 
            this.AsyncEnable.AutoSize = true;
            this.AsyncEnable.Location = new System.Drawing.Point(108, 44);
            this.AsyncEnable.Name = "AsyncEnable";
            this.AsyncEnable.Size = new System.Drawing.Size(88, 17);
            this.AsyncEnable.TabIndex = 8;
            this.AsyncEnable.Text = "AsyncEnable";
            this.AsyncEnable.UseVisualStyleBackColor = true;
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(94, 75);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(76, 23);
            this.btnAsync.TabIndex = 9;
            this.btnAsync.Text = "Async";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.Location = new System.Drawing.Point(611, 425);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(30, 13);
            this.lbl_Clock.TabIndex = 10;
            this.lbl_Clock.Text = "Time";
            // 
            // btn_UpdateAsync
            // 
            this.btn_UpdateAsync.Location = new System.Drawing.Point(99, 121);
            this.btn_UpdateAsync.Name = "btn_UpdateAsync";
            this.btn_UpdateAsync.Size = new System.Drawing.Size(88, 23);
            this.btn_UpdateAsync.TabIndex = 11;
            this.btn_UpdateAsync.Text = "UpdateAsync";
            this.btn_UpdateAsync.UseVisualStyleBackColor = true;
            this.btn_UpdateAsync.Click += new System.EventHandler(this.btn_UpdateAsync_Click);
            // 
            // txb_UpdateColor
            // 
            this.txb_UpdateColor.Location = new System.Drawing.Point(468, 124);
            this.txb_UpdateColor.Name = "txb_UpdateColor";
            this.txb_UpdateColor.Size = new System.Drawing.Size(111, 20);
            this.txb_UpdateColor.TabIndex = 13;
            // 
            // txb_UpdateColories
            // 
            this.txb_UpdateColories.Location = new System.Drawing.Point(585, 124);
            this.txb_UpdateColories.Name = "txb_UpdateColories";
            this.txb_UpdateColories.Size = new System.Drawing.Size(111, 20);
            this.txb_UpdateColories.TabIndex = 14;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(235, 105);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Colories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Where ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(352, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // num_WhereId
            // 
            this.num_WhereId.Location = new System.Drawing.Point(192, 125);
            this.num_WhereId.Name = "num_WhereId";
            this.num_WhereId.Size = new System.Drawing.Size(36, 20);
            this.num_WhereId.TabIndex = 22;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(703, 124);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(37, 13);
            this.lbl_result.TabIndex = 24;
            this.lbl_result.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.num_WhereId);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txb_UpdateColories);
            this.Controls.Add(this.txb_UpdateColor);
            this.Controls.Add(this.btn_UpdateAsync);
            this.Controls.Add(this.lbl_Clock);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.AsyncEnable);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.txb_nameUpdate);
            this.Controls.Add(this.btn_updateSync);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.cmb_provider);
            this.Controls.Add(this.btn_getFactory);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_WhereId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getFactory;
        private System.Windows.Forms.ComboBox cmb_provider;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txb_nameUpdate;
        private System.Windows.Forms.Button btn_updateSync;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.CheckBox AsyncEnable;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Label lbl_Clock;
        private System.Windows.Forms.Button btn_UpdateAsync;
        private System.Windows.Forms.TextBox txb_UpdateColor;
        private System.Windows.Forms.TextBox txb_UpdateColories;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown num_WhereId;
        private System.Windows.Forms.Label lbl_result;
    }
}

