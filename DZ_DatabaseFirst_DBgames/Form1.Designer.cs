
namespace DZ_DatabaseFirst_DBgames
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
            this.btn_searchByName = new System.Windows.Forms.Button();
            this.txb_SearchByName = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.txb_SearchByStyle = new System.Windows.Forms.TextBox();
            this.btn_SearchByStyle = new System.Windows.Forms.Button();
            this.lbl_ByStudioName = new System.Windows.Forms.Label();
            this.txb_StudioName = new System.Windows.Forms.TextBox();
            this.btn_SearchByStudioName = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_searchByDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Query
            // 
            this.dgv_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Query.Location = new System.Drawing.Point(185, 79);
            this.dgv_Query.Name = "dgv_Query";
            this.dgv_Query.Size = new System.Drawing.Size(603, 350);
            this.dgv_Query.TabIndex = 0;
            // 
            // btn_searchByName
            // 
            this.btn_searchByName.Location = new System.Drawing.Point(12, 207);
            this.btn_searchByName.Name = "btn_searchByName";
            this.btn_searchByName.Size = new System.Drawing.Size(75, 23);
            this.btn_searchByName.TabIndex = 1;
            this.btn_searchByName.Text = "Search";
            this.btn_searchByName.UseVisualStyleBackColor = true;
            this.btn_searchByName.Click += new System.EventHandler(this.btn_searchByName_Click);
            // 
            // txb_SearchByName
            // 
            this.txb_SearchByName.Location = new System.Drawing.Point(93, 209);
            this.txb_SearchByName.Name = "txb_SearchByName";
            this.txb_SearchByName.Size = new System.Drawing.Size(80, 20);
            this.txb_SearchByName.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(93, 188);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(50, 13);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "By Name";
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Location = new System.Drawing.Point(12, 53);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowAll.TabIndex = 4;
            this.btn_ShowAll.Text = "ShowAll";
            this.btn_ShowAll.UseVisualStyleBackColor = true;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // lbl_Style
            // 
            this.lbl_Style.AutoSize = true;
            this.lbl_Style.Location = new System.Drawing.Point(99, 146);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(45, 13);
            this.lbl_Style.TabIndex = 7;
            this.lbl_Style.Text = "By Style";
            // 
            // txb_SearchByStyle
            // 
            this.txb_SearchByStyle.Location = new System.Drawing.Point(93, 165);
            this.txb_SearchByStyle.Name = "txb_SearchByStyle";
            this.txb_SearchByStyle.Size = new System.Drawing.Size(79, 20);
            this.txb_SearchByStyle.TabIndex = 6;
            // 
            // btn_SearchByStyle
            // 
            this.btn_SearchByStyle.Location = new System.Drawing.Point(12, 164);
            this.btn_SearchByStyle.Name = "btn_SearchByStyle";
            this.btn_SearchByStyle.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchByStyle.TabIndex = 5;
            this.btn_SearchByStyle.Text = "Search";
            this.btn_SearchByStyle.UseVisualStyleBackColor = true;
            this.btn_SearchByStyle.Click += new System.EventHandler(this.btn_SearchByStudio_Click);
            // 
            // lbl_ByStudioName
            // 
            this.lbl_ByStudioName.AutoSize = true;
            this.lbl_ByStudioName.Location = new System.Drawing.Point(94, 92);
            this.lbl_ByStudioName.Name = "lbl_ByStudioName";
            this.lbl_ByStudioName.Size = new System.Drawing.Size(80, 13);
            this.lbl_ByStudioName.TabIndex = 10;
            this.lbl_ByStudioName.Text = "By StudioName";
            // 
            // txb_StudioName
            // 
            this.txb_StudioName.Location = new System.Drawing.Point(94, 113);
            this.txb_StudioName.Name = "txb_StudioName";
            this.txb_StudioName.Size = new System.Drawing.Size(79, 20);
            this.txb_StudioName.TabIndex = 9;
            // 
            // btn_SearchByStudioName
            // 
            this.btn_SearchByStudioName.Location = new System.Drawing.Point(12, 113);
            this.btn_SearchByStudioName.Name = "btn_SearchByStudioName";
            this.btn_SearchByStudioName.Size = new System.Drawing.Size(72, 23);
            this.btn_SearchByStudioName.TabIndex = 8;
            this.btn_SearchByStudioName.Text = "Search";
            this.btn_SearchByStudioName.UseVisualStyleBackColor = true;
            this.btn_SearchByStudioName.Click += new System.EventHandler(this.btn_SearchByStudioName_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 267);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbl_searchByDate
            // 
            this.lbl_searchByDate.AutoSize = true;
            this.lbl_searchByDate.Location = new System.Drawing.Point(45, 245);
            this.lbl_searchByDate.Name = "lbl_searchByDate";
            this.lbl_searchByDate.Size = new System.Drawing.Size(84, 13);
            this.lbl_searchByDate.TabIndex = 15;
            this.lbl_searchByDate.Text = "By DateRelease";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_searchByDate);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbl_ByStudioName);
            this.Controls.Add(this.txb_StudioName);
            this.Controls.Add(this.btn_SearchByStudioName);
            this.Controls.Add(this.lbl_Style);
            this.Controls.Add(this.txb_SearchByStyle);
            this.Controls.Add(this.btn_SearchByStyle);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txb_SearchByName);
            this.Controls.Add(this.btn_searchByName);
            this.Controls.Add(this.dgv_Query);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Query)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Query;
        private System.Windows.Forms.Button btn_searchByName;
        private System.Windows.Forms.TextBox txb_SearchByName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.Label lbl_Style;
        private System.Windows.Forms.TextBox txb_SearchByStyle;
        private System.Windows.Forms.Button btn_SearchByStyle;
        private System.Windows.Forms.Label lbl_ByStudioName;
        private System.Windows.Forms.TextBox txb_StudioName;
        private System.Windows.Forms.Button btn_SearchByStudioName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_searchByDate;
    }
}

