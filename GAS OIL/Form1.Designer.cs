
namespace GAS_OIL
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
            this.zapravka = new System.Windows.Forms.GroupBox();
            this.labelGrn = new System.Windows.Forms.Label();
            this.labelLitr = new System.Windows.Forms.Label();
            this.Sums = new System.Windows.Forms.TextBox();
            this.Litrs = new System.Windows.Forms.TextBox();
            this.OilPrice = new System.Windows.Forms.Label();
            this.ChoiceLiter = new System.Windows.Forms.GroupBox();
            this.amountCash = new System.Windows.Forms.RadioButton();
            this.amountLitr = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.OilBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZapravkaCheck = new System.Windows.Forms.GroupBox();
            this.currency = new System.Windows.Forms.Label();
            this.OilFullPrice = new System.Windows.Forms.Label();
            this.CafeBox = new System.Windows.Forms.GroupBox();
            this.AmountCocaCola = new System.Windows.Forms.TextBox();
            this.CocaColaPrice = new System.Windows.Forms.TextBox();
            this.AmountPatatoFree = new System.Windows.Forms.TextBox();
            this.PatatoFreePrice = new System.Windows.Forms.TextBox();
            this.AmountGamburger = new System.Windows.Forms.TextBox();
            this.GamburgerPrice = new System.Windows.Forms.TextBox();
            this.AmountHotDogs = new System.Windows.Forms.TextBox();
            this.HotDogPrice = new System.Windows.Forms.TextBox();
            this.checkBox4_CocaCola = new System.Windows.Forms.CheckBox();
            this.checkBox3_PatatoFree = new System.Windows.Forms.CheckBox();
            this.checkBox2_Gamburger = new System.Windows.Forms.CheckBox();
            this.checkBox1_HotDog = new System.Windows.Forms.CheckBox();
            this.LabelAmout = new System.Windows.Forms.Label();
            this.LabelCurency = new System.Windows.Forms.Label();
            this.CafeCheck = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CafeFullPrice = new System.Windows.Forms.Label();
            this.CheckSum = new System.Windows.Forms.GroupBox();
            this.button1_allsum = new System.Windows.Forms.Button();
            this.label3_allsum = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.AdminONOFF = new System.Windows.Forms.CheckBox();
            this.zapravka.SuspendLayout();
            this.ChoiceLiter.SuspendLayout();
            this.ZapravkaCheck.SuspendLayout();
            this.CafeBox.SuspendLayout();
            this.CafeCheck.SuspendLayout();
            this.CheckSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // zapravka
            // 
            this.zapravka.Controls.Add(this.labelGrn);
            this.zapravka.Controls.Add(this.labelLitr);
            this.zapravka.Controls.Add(this.Sums);
            this.zapravka.Controls.Add(this.Litrs);
            this.zapravka.Controls.Add(this.OilPrice);
            this.zapravka.Controls.Add(this.ChoiceLiter);
            this.zapravka.Controls.Add(this.label2);
            this.zapravka.Controls.Add(this.OilBox);
            this.zapravka.Controls.Add(this.label1);
            this.zapravka.Controls.Add(this.ZapravkaCheck);
            this.zapravka.Location = new System.Drawing.Point(12, 12);
            this.zapravka.Name = "zapravka";
            this.zapravka.Size = new System.Drawing.Size(279, 295);
            this.zapravka.TabIndex = 1;
            this.zapravka.TabStop = false;
            this.zapravka.Text = "Автозаправка";
            // 
            // labelGrn
            // 
            this.labelGrn.Location = new System.Drawing.Point(251, 163);
            this.labelGrn.Name = "labelGrn";
            this.labelGrn.Size = new System.Drawing.Size(25, 15);
            this.labelGrn.TabIndex = 10;
            this.labelGrn.Text = "Грн";
            // 
            // labelLitr
            // 
            this.labelLitr.AutoSize = true;
            this.labelLitr.Location = new System.Drawing.Point(256, 130);
            this.labelLitr.Name = "labelLitr";
            this.labelLitr.Size = new System.Drawing.Size(15, 13);
            this.labelLitr.TabIndex = 9;
            this.labelLitr.Text = "Л";
            // 
            // Sums
            // 
            this.Sums.Location = new System.Drawing.Point(149, 160);
            this.Sums.Name = "Sums";
            this.Sums.Size = new System.Drawing.Size(100, 20);
            this.Sums.TabIndex = 8;
            this.Sums.TextChanged += new System.EventHandler(this.Sums_TextChanged);
            this.Sums.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sums_KeyPress);
            // 
            // Litrs
            // 
            this.Litrs.Location = new System.Drawing.Point(149, 123);
            this.Litrs.Name = "Litrs";
            this.Litrs.Size = new System.Drawing.Size(100, 20);
            this.Litrs.TabIndex = 7;
            this.Litrs.TextChanged += new System.EventHandler(this.Litrs_TextChanged);
            this.Litrs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Litrs_KeyPress);
            // 
            // OilPrice
            // 
            this.OilPrice.Location = new System.Drawing.Point(109, 75);
            this.OilPrice.Name = "OilPrice";
            this.OilPrice.Size = new System.Drawing.Size(121, 23);
            this.OilPrice.TabIndex = 5;
            // 
            // ChoiceLiter
            // 
            this.ChoiceLiter.Controls.Add(this.amountCash);
            this.ChoiceLiter.Controls.Add(this.amountLitr);
            this.ChoiceLiter.Location = new System.Drawing.Point(31, 113);
            this.ChoiceLiter.Name = "ChoiceLiter";
            this.ChoiceLiter.Size = new System.Drawing.Size(112, 70);
            this.ChoiceLiter.TabIndex = 6;
            this.ChoiceLiter.TabStop = false;
            this.ChoiceLiter.Enter += new System.EventHandler(this.ChoiceLiter_Enter);
            // 
            // amountCash
            // 
            this.amountCash.AutoSize = true;
            this.amountCash.Location = new System.Drawing.Point(8, 47);
            this.amountCash.Name = "amountCash";
            this.amountCash.Size = new System.Drawing.Size(59, 17);
            this.amountCash.TabIndex = 1;
            this.amountCash.TabStop = true;
            this.amountCash.Text = "Сумма";
            this.amountCash.UseVisualStyleBackColor = true;
            // 
            // amountLitr
            // 
            this.amountLitr.AutoSize = true;
            this.amountLitr.Location = new System.Drawing.Point(7, 10);
            this.amountLitr.Name = "amountLitr";
            this.amountLitr.Size = new System.Drawing.Size(84, 17);
            this.amountLitr.TabIndex = 0;
            this.amountLitr.TabStop = true;
            this.amountLitr.Text = "Количество";
            this.amountLitr.UseVisualStyleBackColor = true;
            this.amountLitr.CheckedChanged += new System.EventHandler(this.amountLitr_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // OilBox
            // 
            this.OilBox.FormattingEnabled = true;
            this.OilBox.Location = new System.Drawing.Point(109, 35);
            this.OilBox.Name = "OilBox";
            this.OilBox.Size = new System.Drawing.Size(121, 21);
            this.OilBox.TabIndex = 3;
            this.OilBox.SelectedIndexChanged += new System.EventHandler(this.OilBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бензин";
            // 
            // ZapravkaCheck
            // 
            this.ZapravkaCheck.Controls.Add(this.currency);
            this.ZapravkaCheck.Controls.Add(this.OilFullPrice);
            this.ZapravkaCheck.Location = new System.Drawing.Point(6, 189);
            this.ZapravkaCheck.Name = "ZapravkaCheck";
            this.ZapravkaCheck.Size = new System.Drawing.Size(225, 100);
            this.ZapravkaCheck.TabIndex = 0;
            this.ZapravkaCheck.TabStop = false;
            this.ZapravkaCheck.Text = "К оплате";
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(159, 74);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(25, 13);
            this.currency.TabIndex = 1;
            this.currency.Text = "Грн";
            // 
            // OilFullPrice
            // 
            this.OilFullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OilFullPrice.Location = new System.Drawing.Point(65, 28);
            this.OilFullPrice.Name = "OilFullPrice";
            this.OilFullPrice.Size = new System.Drawing.Size(95, 60);
            this.OilFullPrice.TabIndex = 0;
            this.OilFullPrice.Click += new System.EventHandler(this.OilFullPrice_Click);
            // 
            // CafeBox
            // 
            this.CafeBox.Controls.Add(this.AmountCocaCola);
            this.CafeBox.Controls.Add(this.CocaColaPrice);
            this.CafeBox.Controls.Add(this.AmountPatatoFree);
            this.CafeBox.Controls.Add(this.PatatoFreePrice);
            this.CafeBox.Controls.Add(this.AmountGamburger);
            this.CafeBox.Controls.Add(this.GamburgerPrice);
            this.CafeBox.Controls.Add(this.AmountHotDogs);
            this.CafeBox.Controls.Add(this.HotDogPrice);
            this.CafeBox.Controls.Add(this.checkBox4_CocaCola);
            this.CafeBox.Controls.Add(this.checkBox3_PatatoFree);
            this.CafeBox.Controls.Add(this.checkBox2_Gamburger);
            this.CafeBox.Controls.Add(this.checkBox1_HotDog);
            this.CafeBox.Controls.Add(this.LabelAmout);
            this.CafeBox.Controls.Add(this.LabelCurency);
            this.CafeBox.Controls.Add(this.CafeCheck);
            this.CafeBox.Location = new System.Drawing.Point(297, 13);
            this.CafeBox.Name = "CafeBox";
            this.CafeBox.Size = new System.Drawing.Size(275, 295);
            this.CafeBox.TabIndex = 2;
            this.CafeBox.TabStop = false;
            this.CafeBox.Text = "Мини-Кафе";
            // 
            // AmountCocaCola
            // 
            this.AmountCocaCola.Location = new System.Drawing.Point(203, 147);
            this.AmountCocaCola.Name = "AmountCocaCola";
            this.AmountCocaCola.Size = new System.Drawing.Size(66, 20);
            this.AmountCocaCola.TabIndex = 15;
            this.AmountCocaCola.TextChanged += new System.EventHandler(this.AmountCocaCola_TextChanged);
            this.AmountCocaCola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountCocaCola_KeyPress);
            // 
            // CocaColaPrice
            // 
            this.CocaColaPrice.Location = new System.Drawing.Point(150, 147);
            this.CocaColaPrice.Name = "CocaColaPrice";
            this.CocaColaPrice.Size = new System.Drawing.Size(47, 20);
            this.CocaColaPrice.TabIndex = 14;
            // 
            // AmountPatatoFree
            // 
            this.AmountPatatoFree.Location = new System.Drawing.Point(203, 117);
            this.AmountPatatoFree.Name = "AmountPatatoFree";
            this.AmountPatatoFree.Size = new System.Drawing.Size(66, 20);
            this.AmountPatatoFree.TabIndex = 13;
            this.AmountPatatoFree.TextChanged += new System.EventHandler(this.AmountPatatoFree_TextChanged);
            this.AmountPatatoFree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountPatatoFree_KeyPress);
            // 
            // PatatoFreePrice
            // 
            this.PatatoFreePrice.Location = new System.Drawing.Point(150, 117);
            this.PatatoFreePrice.Name = "PatatoFreePrice";
            this.PatatoFreePrice.Size = new System.Drawing.Size(47, 20);
            this.PatatoFreePrice.TabIndex = 12;
            // 
            // AmountGamburger
            // 
            this.AmountGamburger.Location = new System.Drawing.Point(203, 86);
            this.AmountGamburger.Name = "AmountGamburger";
            this.AmountGamburger.Size = new System.Drawing.Size(66, 20);
            this.AmountGamburger.TabIndex = 11;
            this.AmountGamburger.TextChanged += new System.EventHandler(this.AmountGamburger_TextChanged);
            this.AmountGamburger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountGamburger_KeyPress);
            // 
            // GamburgerPrice
            // 
            this.GamburgerPrice.Location = new System.Drawing.Point(150, 86);
            this.GamburgerPrice.Name = "GamburgerPrice";
            this.GamburgerPrice.Size = new System.Drawing.Size(47, 20);
            this.GamburgerPrice.TabIndex = 10;
            // 
            // AmountHotDogs
            // 
            this.AmountHotDogs.Location = new System.Drawing.Point(203, 56);
            this.AmountHotDogs.Name = "AmountHotDogs";
            this.AmountHotDogs.Size = new System.Drawing.Size(66, 20);
            this.AmountHotDogs.TabIndex = 9;
            this.AmountHotDogs.TextChanged += new System.EventHandler(this.AmountHotDogs_TextChanged);
            this.AmountHotDogs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountHotDogs_KeyPress);
            // 
            // HotDogPrice
            // 
            this.HotDogPrice.Location = new System.Drawing.Point(150, 56);
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.Size = new System.Drawing.Size(47, 20);
            this.HotDogPrice.TabIndex = 8;
            this.HotDogPrice.TextChanged += new System.EventHandler(this.HotDogPrice_TextChanged);
            // 
            // checkBox4_CocaCola
            // 
            this.checkBox4_CocaCola.AutoSize = true;
            this.checkBox4_CocaCola.Location = new System.Drawing.Point(11, 147);
            this.checkBox4_CocaCola.Name = "checkBox4_CocaCola";
            this.checkBox4_CocaCola.Size = new System.Drawing.Size(79, 17);
            this.checkBox4_CocaCola.TabIndex = 7;
            this.checkBox4_CocaCola.Text = "Кока-Кола";
            this.checkBox4_CocaCola.UseVisualStyleBackColor = true;
            this.checkBox4_CocaCola.CheckedChanged += new System.EventHandler(this.checkBox4_CocaCola_CheckedChanged);
            // 
            // checkBox3_PatatoFree
            // 
            this.checkBox3_PatatoFree.AutoSize = true;
            this.checkBox3_PatatoFree.Location = new System.Drawing.Point(11, 117);
            this.checkBox3_PatatoFree.Name = "checkBox3_PatatoFree";
            this.checkBox3_PatatoFree.Size = new System.Drawing.Size(102, 17);
            this.checkBox3_PatatoFree.TabIndex = 6;
            this.checkBox3_PatatoFree.Text = "Картошка-Фри";
            this.checkBox3_PatatoFree.UseVisualStyleBackColor = true;
            this.checkBox3_PatatoFree.CheckedChanged += new System.EventHandler(this.checkBox3_PatatoFree_CheckedChanged);
            // 
            // checkBox2_Gamburger
            // 
            this.checkBox2_Gamburger.AutoSize = true;
            this.checkBox2_Gamburger.Location = new System.Drawing.Point(11, 86);
            this.checkBox2_Gamburger.Name = "checkBox2_Gamburger";
            this.checkBox2_Gamburger.Size = new System.Drawing.Size(80, 17);
            this.checkBox2_Gamburger.TabIndex = 5;
            this.checkBox2_Gamburger.Text = "Гамбургер";
            this.checkBox2_Gamburger.UseVisualStyleBackColor = true;
            this.checkBox2_Gamburger.CheckedChanged += new System.EventHandler(this.checkBox2_Gamburger_CheckedChanged);
            // 
            // checkBox1_HotDog
            // 
            this.checkBox1_HotDog.AutoSize = true;
            this.checkBox1_HotDog.Location = new System.Drawing.Point(11, 55);
            this.checkBox1_HotDog.Name = "checkBox1_HotDog";
            this.checkBox1_HotDog.Size = new System.Drawing.Size(67, 17);
            this.checkBox1_HotDog.TabIndex = 4;
            this.checkBox1_HotDog.Text = "Хот-Дог";
            this.checkBox1_HotDog.UseVisualStyleBackColor = true;
            this.checkBox1_HotDog.CheckedChanged += new System.EventHandler(this.checkBox1_HotDog_CheckedChanged);
            // 
            // LabelAmout
            // 
            this.LabelAmout.AutoSize = true;
            this.LabelAmout.Location = new System.Drawing.Point(203, 34);
            this.LabelAmout.Name = "LabelAmout";
            this.LabelAmout.Size = new System.Drawing.Size(66, 13);
            this.LabelAmout.TabIndex = 3;
            this.LabelAmout.Text = "Количество";
            // 
            // LabelCurency
            // 
            this.LabelCurency.AutoSize = true;
            this.LabelCurency.Location = new System.Drawing.Point(157, 34);
            this.LabelCurency.Name = "LabelCurency";
            this.LabelCurency.Size = new System.Drawing.Size(33, 13);
            this.LabelCurency.TabIndex = 2;
            this.LabelCurency.Text = "Цена";
            // 
            // CafeCheck
            // 
            this.CafeCheck.Controls.Add(this.label4);
            this.CafeCheck.Controls.Add(this.CafeFullPrice);
            this.CafeCheck.Location = new System.Drawing.Point(6, 188);
            this.CafeCheck.Name = "CafeCheck";
            this.CafeCheck.Size = new System.Drawing.Size(230, 100);
            this.CafeCheck.TabIndex = 1;
            this.CafeCheck.TabStop = false;
            this.CafeCheck.Text = "К оплате";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(179, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Грн";
            // 
            // CafeFullPrice
            // 
            this.CafeFullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CafeFullPrice.Location = new System.Drawing.Point(25, 28);
            this.CafeFullPrice.Name = "CafeFullPrice";
            this.CafeFullPrice.Size = new System.Drawing.Size(148, 60);
            this.CafeFullPrice.TabIndex = 0;
            // 
            // CheckSum
            // 
            this.CheckSum.Controls.Add(this.button1_allsum);
            this.CheckSum.Controls.Add(this.label3_allsum);
            this.CheckSum.Location = new System.Drawing.Point(12, 314);
            this.CheckSum.Name = "CheckSum";
            this.CheckSum.Size = new System.Drawing.Size(560, 104);
            this.CheckSum.TabIndex = 3;
            this.CheckSum.TabStop = false;
            this.CheckSum.Text = "Всего к оплате";
            // 
            // button1_allsum
            // 
            this.button1_allsum.Location = new System.Drawing.Point(101, 20);
            this.button1_allsum.Name = "button1_allsum";
            this.button1_allsum.Size = new System.Drawing.Size(178, 77);
            this.button1_allsum.TabIndex = 1;
            this.button1_allsum.Text = "Посчитать";
            this.button1_allsum.UseVisualStyleBackColor = true;
            this.button1_allsum.Click += new System.EventHandler(this.button1_allsum_Click);
            // 
            // label3_allsum
            // 
            this.label3_allsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_allsum.Location = new System.Drawing.Point(293, 19);
            this.label3_allsum.Name = "label3_allsum";
            this.label3_allsum.Size = new System.Drawing.Size(156, 78);
            this.label3_allsum.TabIndex = 0;
            this.label3_allsum.Text = "label3";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(11, 422);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Очистить!";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminONOFF
            // 
            this.AdminONOFF.AutoSize = true;
            this.AdminONOFF.Location = new System.Drawing.Point(447, 427);
            this.AdminONOFF.Name = "AdminONOFF";
            this.AdminONOFF.Size = new System.Drawing.Size(96, 17);
            this.AdminONOFF.TabIndex = 5;
            this.AdminONOFF.Text = "AdminON\\OFF";
            this.AdminONOFF.UseVisualStyleBackColor = true;
            this.AdminONOFF.CheckedChanged += new System.EventHandler(this.AdminONOFF_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.AdminONOFF);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CheckSum);
            this.Controls.Add(this.CafeBox);
            this.Controls.Add(this.zapravka);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.zapravka.ResumeLayout(false);
            this.zapravka.PerformLayout();
            this.ChoiceLiter.ResumeLayout(false);
            this.ChoiceLiter.PerformLayout();
            this.ZapravkaCheck.ResumeLayout(false);
            this.ZapravkaCheck.PerformLayout();
            this.CafeBox.ResumeLayout(false);
            this.CafeBox.PerformLayout();
            this.CafeCheck.ResumeLayout(false);
            this.CheckSum.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox zapravka;
        private System.Windows.Forms.GroupBox CafeBox;
        private System.Windows.Forms.GroupBox CheckSum;
        private System.Windows.Forms.GroupBox ZapravkaCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CafeCheck;
        private System.Windows.Forms.ComboBox OilBox;
        private System.Windows.Forms.Label currency;
        private System.Windows.Forms.Label OilFullPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OilPrice;
        private System.Windows.Forms.GroupBox ChoiceLiter;
        private System.Windows.Forms.RadioButton amountCash;
        private System.Windows.Forms.RadioButton amountLitr;
        private System.Windows.Forms.TextBox Sums;
        private System.Windows.Forms.TextBox Litrs;
        private System.Windows.Forms.Label labelGrn;
        private System.Windows.Forms.Label labelLitr;
        private System.Windows.Forms.Label LabelAmout;
        private System.Windows.Forms.Label LabelCurency;
        private System.Windows.Forms.CheckBox checkBox4_CocaCola;
        private System.Windows.Forms.CheckBox checkBox3_PatatoFree;
        private System.Windows.Forms.CheckBox checkBox2_Gamburger;
        private System.Windows.Forms.CheckBox checkBox1_HotDog;
        private System.Windows.Forms.TextBox AmountCocaCola;
        private System.Windows.Forms.TextBox CocaColaPrice;
        private System.Windows.Forms.TextBox AmountPatatoFree;
        private System.Windows.Forms.TextBox PatatoFreePrice;
        private System.Windows.Forms.TextBox AmountGamburger;
        private System.Windows.Forms.TextBox GamburgerPrice;
        private System.Windows.Forms.TextBox AmountHotDogs;
        private System.Windows.Forms.TextBox HotDogPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CafeFullPrice;
        private System.Windows.Forms.Button button1_allsum;
        private System.Windows.Forms.Label label3_allsum;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox AdminONOFF;
    }
}

