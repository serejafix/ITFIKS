
namespace DZ_Provider_Async
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dvg_data = new System.Windows.Forms.DataGridView();
            this.cmbProviders = new System.Windows.Forms.ComboBox();
            this.btnGetProvider = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelCalories = new System.Windows.Forms.Label();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxVegOrFruits = new System.Windows.Forms.CheckBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDelete = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(566, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "select * from FruitsAndVegetables";
            // 
            // dvg_data
            // 
            this.dvg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_data.Location = new System.Drawing.Point(25, 203);
            this.dvg_data.Name = "dvg_data";
            this.dvg_data.Size = new System.Drawing.Size(724, 222);
            this.dvg_data.TabIndex = 2;
            // 
            // cmbProviders
            // 
            this.cmbProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProviders.FormattingEnabled = true;
            this.cmbProviders.Location = new System.Drawing.Point(140, 12);
            this.cmbProviders.Name = "cmbProviders";
            this.cmbProviders.Size = new System.Drawing.Size(566, 21);
            this.cmbProviders.TabIndex = 3;
            this.cmbProviders.SelectedIndexChanged += new System.EventHandler(this.cmbProviders_SelectedIndexChanged);
            // 
            // btnGetProvider
            // 
            this.btnGetProvider.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGetProvider.Location = new System.Drawing.Point(25, 12);
            this.btnGetProvider.Name = "btnGetProvider";
            this.btnGetProvider.Size = new System.Drawing.Size(75, 23);
            this.btnGetProvider.TabIndex = 4;
            this.btnGetProvider.Text = "Получить!";
            this.btnGetProvider.UseVisualStyleBackColor = false;
            this.btnGetProvider.Click += new System.EventHandler(this.btnGetProvider_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(22, 428);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(25, 107);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(183, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(183, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(302, 92);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 10;
            this.labelType.Text = "Type";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(417, 92);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 13);
            this.labelColor.TabIndex = 12;
            this.labelColor.Text = "Color";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(417, 111);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 11;
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Location = new System.Drawing.Point(523, 92);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(44, 13);
            this.labelCalories.TabIndex = 14;
            this.labelCalories.Text = "Calories";
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(523, 111);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalories.TabIndex = 13;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(115, 92);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(51, 13);
            this.labelId.TabIndex = 15;
            this.labelId.Text = "Where Id";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 110);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // checkBoxVegOrFruits
            // 
            this.checkBoxVegOrFruits.AutoSize = true;
            this.checkBoxVegOrFruits.Location = new System.Drawing.Point(305, 114);
            this.checkBoxVegOrFruits.Name = "checkBoxVegOrFruits";
            this.checkBoxVegOrFruits.Size = new System.Drawing.Size(91, 17);
            this.checkBoxVegOrFruits.TabIndex = 17;
            this.checkBoxVegOrFruits.Text = "Фрукт\\овощ";
            this.checkBoxVegOrFruits.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(25, 156);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(85, 23);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Where Id";
            // 
            // numericUpDownDelete
            // 
            this.numericUpDownDelete.Location = new System.Drawing.Point(116, 160);
            this.numericUpDownDelete.Name = "numericUpDownDelete";
            this.numericUpDownDelete.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownDelete.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.checkBoxVegOrFruits);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnGetProvider);
            this.Controls.Add(this.cmbProviders);
            this.Controls.Add(this.dvg_data);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dvg_data;
        private System.Windows.Forms.ComboBox cmbProviders;
        private System.Windows.Forms.Button btnGetProvider;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.TextBox textBoxCalories;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxVegOrFruits;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDelete;
    }
}

