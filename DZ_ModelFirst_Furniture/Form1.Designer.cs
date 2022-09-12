
namespace DZ_ModelFirst_Furniture
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
            this.btn_InsertClients = new System.Windows.Forms.Button();
            this.txb_Fio = new System.Windows.Forms.TextBox();
            this.txb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_FIO = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_insertCostPrice = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_InsertCostPrice = new System.Windows.Forms.TextBox();
            this.txb_insertName = new System.Windows.Forms.TextBox();
            this.btn_InsertProduct = new System.Windows.Forms.Button();
            this.lbl_InsertWeight = new System.Windows.Forms.Label();
            this.txb_InsertWeight = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.txb_InsertHeight = new System.Windows.Forms.TextBox();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txb_Width = new System.Windows.Forms.TextBox();
            this.lbl_Material = new System.Windows.Forms.Label();
            this.txb_InsertMaterial = new System.Windows.Forms.TextBox();
            this.lbl_ClientId = new System.Windows.Forms.Label();
            this.lbl_DateSale = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txb_InsertPrice = new System.Windows.Forms.TextBox();
            this.btn_InsertProductSale = new System.Windows.Forms.Button();
            this.lbl_PruductID = new System.Windows.Forms.Label();
            this.num_InsertClientId = new System.Windows.Forms.NumericUpDown();
            this.num_InsertProductId = new System.Windows.Forms.NumericUpDown();
            this.dtPicker_insertDateTime = new System.Windows.Forms.DateTimePicker();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.dtPick_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtPick_EndDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.btn_Exec = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.gr_box_1 = new System.Windows.Forms.GroupBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.btn_Exec3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_InsertClientId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_InsertProductId)).BeginInit();
            this.gr_box_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Query
            // 
            this.dgv_Query.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Query.Location = new System.Drawing.Point(9, 148);
            this.dgv_Query.Name = "dgv_Query";
            this.dgv_Query.Size = new System.Drawing.Size(543, 291);
            this.dgv_Query.TabIndex = 0;
            // 
            // btn_InsertClients
            // 
            this.btn_InsertClients.Location = new System.Drawing.Point(5, 32);
            this.btn_InsertClients.Name = "btn_InsertClients";
            this.btn_InsertClients.Size = new System.Drawing.Size(114, 23);
            this.btn_InsertClients.TabIndex = 1;
            this.btn_InsertClients.Text = "InsertClient";
            this.btn_InsertClients.UseVisualStyleBackColor = true;
            this.btn_InsertClients.Click += new System.EventHandler(this.btn_InsertClients_Click);
            // 
            // txb_Fio
            // 
            this.txb_Fio.Location = new System.Drawing.Point(125, 35);
            this.txb_Fio.Name = "txb_Fio";
            this.txb_Fio.Size = new System.Drawing.Size(100, 20);
            this.txb_Fio.TabIndex = 2;
            this.txb_Fio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Fio_KeyPress);
            // 
            // txb_PhoneNumber
            // 
            this.txb_PhoneNumber.Location = new System.Drawing.Point(231, 36);
            this.txb_PhoneNumber.Name = "txb_PhoneNumber";
            this.txb_PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txb_PhoneNumber.TabIndex = 3;
            this.txb_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_PhoneNumber_KeyPress);
            // 
            // lbl_FIO
            // 
            this.lbl_FIO.AutoSize = true;
            this.lbl_FIO.Location = new System.Drawing.Point(125, 16);
            this.lbl_FIO.Name = "lbl_FIO";
            this.lbl_FIO.Size = new System.Drawing.Size(24, 13);
            this.lbl_FIO.TabIndex = 4;
            this.lbl_FIO.Text = "FIO";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(228, 16);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(75, 13);
            this.lbl_PhoneNumber.TabIndex = 5;
            this.lbl_PhoneNumber.Text = "PhoneNumber";
            // 
            // lbl_insertCostPrice
            // 
            this.lbl_insertCostPrice.AutoSize = true;
            this.lbl_insertCostPrice.Location = new System.Drawing.Point(229, 59);
            this.lbl_insertCostPrice.Name = "lbl_insertCostPrice";
            this.lbl_insertCostPrice.Size = new System.Drawing.Size(52, 13);
            this.lbl_insertCostPrice.TabIndex = 10;
            this.lbl_insertCostPrice.Text = "CostPrice";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(126, 59);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_InsertCostPrice
            // 
            this.txb_InsertCostPrice.Location = new System.Drawing.Point(231, 79);
            this.txb_InsertCostPrice.Name = "txb_InsertCostPrice";
            this.txb_InsertCostPrice.Size = new System.Drawing.Size(100, 20);
            this.txb_InsertCostPrice.TabIndex = 8;
            // 
            // txb_insertName
            // 
            this.txb_insertName.Location = new System.Drawing.Point(125, 78);
            this.txb_insertName.Name = "txb_insertName";
            this.txb_insertName.Size = new System.Drawing.Size(100, 20);
            this.txb_insertName.TabIndex = 7;
            // 
            // btn_InsertProduct
            // 
            this.btn_InsertProduct.Location = new System.Drawing.Point(5, 75);
            this.btn_InsertProduct.Name = "btn_InsertProduct";
            this.btn_InsertProduct.Size = new System.Drawing.Size(114, 23);
            this.btn_InsertProduct.TabIndex = 6;
            this.btn_InsertProduct.Text = "InsertProduct";
            this.btn_InsertProduct.UseVisualStyleBackColor = true;
            this.btn_InsertProduct.Click += new System.EventHandler(this.btn_InsertProduct_Click);
            // 
            // lbl_InsertWeight
            // 
            this.lbl_InsertWeight.AutoSize = true;
            this.lbl_InsertWeight.Location = new System.Drawing.Point(335, 59);
            this.lbl_InsertWeight.Name = "lbl_InsertWeight";
            this.lbl_InsertWeight.Size = new System.Drawing.Size(41, 13);
            this.lbl_InsertWeight.TabIndex = 12;
            this.lbl_InsertWeight.Text = "Weight";
            // 
            // txb_InsertWeight
            // 
            this.txb_InsertWeight.Location = new System.Drawing.Point(337, 79);
            this.txb_InsertWeight.Name = "txb_InsertWeight";
            this.txb_InsertWeight.Size = new System.Drawing.Size(100, 20);
            this.txb_InsertWeight.TabIndex = 11;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(441, 59);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(38, 13);
            this.lbl_Height.TabIndex = 14;
            this.lbl_Height.Text = "Height";
            // 
            // txb_InsertHeight
            // 
            this.txb_InsertHeight.Location = new System.Drawing.Point(443, 79);
            this.txb_InsertHeight.Name = "txb_InsertHeight";
            this.txb_InsertHeight.Size = new System.Drawing.Size(100, 20);
            this.txb_InsertHeight.TabIndex = 13;
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(547, 59);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(35, 13);
            this.lbl_Width.TabIndex = 16;
            this.lbl_Width.Text = "Width";
            // 
            // txb_Width
            // 
            this.txb_Width.Location = new System.Drawing.Point(549, 79);
            this.txb_Width.Name = "txb_Width";
            this.txb_Width.Size = new System.Drawing.Size(100, 20);
            this.txb_Width.TabIndex = 15;
            // 
            // lbl_Material
            // 
            this.lbl_Material.AutoSize = true;
            this.lbl_Material.Location = new System.Drawing.Point(653, 59);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(44, 13);
            this.lbl_Material.TabIndex = 18;
            this.lbl_Material.Text = "Material";
            // 
            // txb_InsertMaterial
            // 
            this.txb_InsertMaterial.Location = new System.Drawing.Point(655, 79);
            this.txb_InsertMaterial.Name = "txb_InsertMaterial";
            this.txb_InsertMaterial.Size = new System.Drawing.Size(100, 20);
            this.txb_InsertMaterial.TabIndex = 17;
            // 
            // lbl_ClientId
            // 
            this.lbl_ClientId.AutoSize = true;
            this.lbl_ClientId.Location = new System.Drawing.Point(547, 103);
            this.lbl_ClientId.Name = "lbl_ClientId";
            this.lbl_ClientId.Size = new System.Drawing.Size(48, 13);
            this.lbl_ClientId.TabIndex = 25;
            this.lbl_ClientId.Text = "Client_Id";
            // 
            // lbl_DateSale
            // 
            this.lbl_DateSale.AutoSize = true;
            this.lbl_DateSale.Location = new System.Drawing.Point(229, 103);
            this.lbl_DateSale.Name = "lbl_DateSale";
            this.lbl_DateSale.Size = new System.Drawing.Size(51, 13);
            this.lbl_DateSale.TabIndex = 23;
            this.lbl_DateSale.Text = "DateSale";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(126, 103);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(31, 13);
            this.lbl_Price.TabIndex = 22;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_InsertPrice
            // 
            this.txb_InsertPrice.Location = new System.Drawing.Point(125, 122);
            this.txb_InsertPrice.Name = "txb_InsertPrice";
            this.txb_InsertPrice.Size = new System.Drawing.Size(100, 20);
            this.txb_InsertPrice.TabIndex = 20;
            // 
            // btn_InsertProductSale
            // 
            this.btn_InsertProductSale.Location = new System.Drawing.Point(9, 119);
            this.btn_InsertProductSale.Name = "btn_InsertProductSale";
            this.btn_InsertProductSale.Size = new System.Drawing.Size(110, 23);
            this.btn_InsertProductSale.TabIndex = 19;
            this.btn_InsertProductSale.Text = "InsertProductSale";
            this.btn_InsertProductSale.UseVisualStyleBackColor = true;
            this.btn_InsertProductSale.Click += new System.EventHandler(this.btn_InsertProductSale_Click);
            // 
            // lbl_PruductID
            // 
            this.lbl_PruductID.AutoSize = true;
            this.lbl_PruductID.Location = new System.Drawing.Point(654, 103);
            this.lbl_PruductID.Name = "lbl_PruductID";
            this.lbl_PruductID.Size = new System.Drawing.Size(59, 13);
            this.lbl_PruductID.TabIndex = 27;
            this.lbl_PruductID.Text = "Pruduct_Id";
            // 
            // num_InsertClientId
            // 
            this.num_InsertClientId.Location = new System.Drawing.Point(550, 122);
            this.num_InsertClientId.Name = "num_InsertClientId";
            this.num_InsertClientId.Size = new System.Drawing.Size(99, 20);
            this.num_InsertClientId.TabIndex = 28;
            // 
            // num_InsertProductId
            // 
            this.num_InsertProductId.Location = new System.Drawing.Point(657, 122);
            this.num_InsertProductId.Name = "num_InsertProductId";
            this.num_InsertProductId.Size = new System.Drawing.Size(99, 20);
            this.num_InsertProductId.TabIndex = 29;
            // 
            // dtPicker_insertDateTime
            // 
            this.dtPicker_insertDateTime.Location = new System.Drawing.Point(232, 122);
            this.dtPicker_insertDateTime.Name = "dtPicker_insertDateTime";
            this.dtPicker_insertDateTime.Size = new System.Drawing.Size(311, 20);
            this.dtPicker_insertDateTime.TabIndex = 30;
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(76, 116);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(75, 23);
            this.btn_Execute.TabIndex = 31;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = true;
            
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(23, 8);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(197, 13);
            this.lbl_1.TabIndex = 32;
            this.lbl_1.Text = "Список продаж за указанный период";
            // 
            // dtPick_StartDate
            // 
            this.dtPick_StartDate.Location = new System.Drawing.Point(3, 40);
            this.dtPick_StartDate.Name = "dtPick_StartDate";
            this.dtPick_StartDate.Size = new System.Drawing.Size(237, 20);
            this.dtPick_StartDate.TabIndex = 33;
            // 
            // dtPick_EndDate
            // 
            this.dtPick_EndDate.Location = new System.Drawing.Point(3, 81);
            this.dtPick_EndDate.Name = "dtPick_EndDate";
            this.dtPick_EndDate.Size = new System.Drawing.Size(237, 20);
            this.dtPick_EndDate.TabIndex = 34;
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(90, 23);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_StartDate.TabIndex = 35;
            this.lbl_StartDate.Text = "StartDate";
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(90, 64);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(49, 13);
            this.lbl_EndDate.TabIndex = 36;
            this.lbl_EndDate.Text = "EndDate";
            // 
            // btn_Exec
            // 
            this.btn_Exec.Location = new System.Drawing.Point(631, 324);
            this.btn_Exec.Name = "btn_Exec";
            this.btn_Exec.Size = new System.Drawing.Size(75, 23);
            this.btn_Exec.TabIndex = 37;
            this.btn_Exec.Text = "Execute";
            this.btn_Exec.UseVisualStyleBackColor = true;
            this.btn_Exec.Click += new System.EventHandler(this.btn_Exec_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(578, 304);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(202, 13);
            this.lbl_2.TabIndex = 38;
            this.lbl_2.Text = "Показать топ 5 клиентов по покупкам";
            // 
            // gr_box_1
            // 
            this.gr_box_1.Controls.Add(this.btn_Execute);
            this.gr_box_1.Controls.Add(this.lbl_1);
            this.gr_box_1.Controls.Add(this.dtPick_StartDate);
            this.gr_box_1.Controls.Add(this.lbl_EndDate);
            this.gr_box_1.Controls.Add(this.dtPick_EndDate);
            this.gr_box_1.Controls.Add(this.lbl_StartDate);
            this.gr_box_1.Location = new System.Drawing.Point(555, 142);
            this.gr_box_1.Name = "gr_box_1";
            this.gr_box_1.Size = new System.Drawing.Size(241, 159);
            this.gr_box_1.TabIndex = 39;
            this.gr_box_1.TabStop = false;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(578, 360);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(202, 13);
            this.lbl_3.TabIndex = 41;
            this.lbl_3.Text = "Показать топ 5 клиентов по покупкам";
            // 
            // btn_Exec3
            // 
            this.btn_Exec3.Location = new System.Drawing.Point(631, 380);
            this.btn_Exec3.Name = "btn_Exec3";
            this.btn_Exec3.Size = new System.Drawing.Size(75, 23);
            this.btn_Exec3.TabIndex = 40;
            this.btn_Exec3.Text = "Execute";
            this.btn_Exec3.UseVisualStyleBackColor = true;
            this.btn_Exec3.Click += new System.EventHandler(this.btn_Exec3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.btn_Exec3);
            this.Controls.Add(this.gr_box_1);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_Exec);
            this.Controls.Add(this.dtPicker_insertDateTime);
            this.Controls.Add(this.num_InsertProductId);
            this.Controls.Add(this.num_InsertClientId);
            this.Controls.Add(this.lbl_PruductID);
            this.Controls.Add(this.lbl_ClientId);
            this.Controls.Add(this.lbl_DateSale);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.txb_InsertPrice);
            this.Controls.Add(this.btn_InsertProductSale);
            this.Controls.Add(this.lbl_Material);
            this.Controls.Add(this.txb_InsertMaterial);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.txb_Width);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.txb_InsertHeight);
            this.Controls.Add(this.lbl_InsertWeight);
            this.Controls.Add(this.txb_InsertWeight);
            this.Controls.Add(this.lbl_insertCostPrice);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txb_InsertCostPrice);
            this.Controls.Add(this.txb_insertName);
            this.Controls.Add(this.btn_InsertProduct);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.lbl_FIO);
            this.Controls.Add(this.txb_PhoneNumber);
            this.Controls.Add(this.txb_Fio);
            this.Controls.Add(this.btn_InsertClients);
            this.Controls.Add(this.dgv_Query);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_InsertClientId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_InsertProductId)).EndInit();
            this.gr_box_1.ResumeLayout(false);
            this.gr_box_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Query;
        private System.Windows.Forms.Button btn_InsertClients;
        private System.Windows.Forms.TextBox txb_Fio;
        private System.Windows.Forms.TextBox txb_PhoneNumber;
        private System.Windows.Forms.Label lbl_FIO;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_insertCostPrice;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_InsertCostPrice;
        private System.Windows.Forms.TextBox txb_insertName;
        private System.Windows.Forms.Button btn_InsertProduct;
        private System.Windows.Forms.Label lbl_InsertWeight;
        private System.Windows.Forms.TextBox txb_InsertWeight;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TextBox txb_InsertHeight;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txb_Width;
        private System.Windows.Forms.Label lbl_Material;
        private System.Windows.Forms.TextBox txb_InsertMaterial;
        private System.Windows.Forms.Label lbl_ClientId;
        private System.Windows.Forms.Label lbl_DateSale;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txb_InsertPrice;
        private System.Windows.Forms.Button btn_InsertProductSale;
        private System.Windows.Forms.Label lbl_PruductID;
        private System.Windows.Forms.NumericUpDown num_InsertClientId;
        private System.Windows.Forms.NumericUpDown num_InsertProductId;
        private System.Windows.Forms.DateTimePicker dtPicker_insertDateTime;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.DateTimePicker dtPick_StartDate;
        private System.Windows.Forms.DateTimePicker dtPick_EndDate;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Button btn_Exec;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.GroupBox gr_box_1;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Button btn_Exec3;
    }
}

