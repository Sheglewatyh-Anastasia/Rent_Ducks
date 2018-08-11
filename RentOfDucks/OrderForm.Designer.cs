namespace RentOfDucks
{
    partial class OrderForm
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
            this.cBx_Red = new System.Windows.Forms.CheckBox();
            this.cBx_Green = new System.Windows.Forms.CheckBox();
            this.cBx_Black = new System.Windows.Forms.CheckBox();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.numUpDown_Red = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_Green = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_Black = new System.Windows.Forms.NumericUpDown();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.dTP_DateBeginning = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateBeginning = new System.Windows.Forms.Label();
            this.lbl_DateExpiration = new System.Windows.Forms.Label();
            this.dTP_DateExpiration = new System.Windows.Forms.DateTimePicker();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_PriceRed = new System.Windows.Forms.Label();
            this.lbl_PriceGreen = new System.Windows.Forms.Label();
            this.lbl_PriceBlack = new System.Windows.Forms.Label();
            this.lbl_InStockBlack = new System.Windows.Forms.Label();
            this.lbl_InStockGreen = new System.Windows.Forms.Label();
            this.lbl_InStockRed = new System.Windows.Forms.Label();
            this.lbl_InStock = new System.Windows.Forms.Label();
            this.gBx_Term = new System.Windows.Forms.GroupBox();
            this.gBx_Main = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gBx_Preliminary = new System.Windows.Forms.GroupBox();
            this.btn_UpdatePreliminary = new System.Windows.Forms.Button();
            this.lbl_Price_Result_Value = new System.Windows.Forms.Label();
            this.lbl_Price_Result = new System.Windows.Forms.Label();
            this.lbl_All_Days_Value = new System.Windows.Forms.Label();
            this.lbl_All_Days = new System.Windows.Forms.Label();
            this.lbl_Number_All_Duck_Value = new System.Windows.Forms.Label();
            this.lbl_Number_All_Duck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Black)).BeginInit();
            this.gBx_Term.SuspendLayout();
            this.gBx_Main.SuspendLayout();
            this.gBx_Preliminary.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBx_Red
            // 
            this.cBx_Red.AutoSize = true;
            this.cBx_Red.Location = new System.Drawing.Point(12, 50);
            this.cBx_Red.Name = "cBx_Red";
            this.cBx_Red.Size = new System.Drawing.Size(71, 17);
            this.cBx_Red.TabIndex = 0;
            this.cBx_Red.Text = "Красный";
            this.cBx_Red.UseVisualStyleBackColor = true;
            this.cBx_Red.CheckedChanged += new System.EventHandler(this.cBx_Red_CheckedChanged);
            // 
            // cBx_Green
            // 
            this.cBx_Green.AutoSize = true;
            this.cBx_Green.Location = new System.Drawing.Point(12, 73);
            this.cBx_Green.Name = "cBx_Green";
            this.cBx_Green.Size = new System.Drawing.Size(71, 17);
            this.cBx_Green.TabIndex = 1;
            this.cBx_Green.Text = "Зеленый";
            this.cBx_Green.UseVisualStyleBackColor = true;
            this.cBx_Green.CheckedChanged += new System.EventHandler(this.cBx_Green_CheckedChanged);
            // 
            // cBx_Black
            // 
            this.cBx_Black.AutoSize = true;
            this.cBx_Black.Location = new System.Drawing.Point(12, 96);
            this.cBx_Black.Name = "cBx_Black";
            this.cBx_Black.Size = new System.Drawing.Size(66, 17);
            this.cBx_Black.TabIndex = 2;
            this.cBx_Black.Text = "Черный";
            this.cBx_Black.UseVisualStyleBackColor = true;
            this.cBx_Black.CheckedChanged += new System.EventHandler(this.cBx_Black_CheckedChanged);
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(9, 25);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(35, 13);
            this.lbl_Color.TabIndex = 3;
            this.lbl_Color.Text = "Цвет:";
            // 
            // numUpDown_Red
            // 
            this.numUpDown_Red.Location = new System.Drawing.Point(99, 47);
            this.numUpDown_Red.Name = "numUpDown_Red";
            this.numUpDown_Red.Size = new System.Drawing.Size(88, 20);
            this.numUpDown_Red.TabIndex = 4;
            // 
            // numUpDown_Green
            // 
            this.numUpDown_Green.Location = new System.Drawing.Point(99, 70);
            this.numUpDown_Green.Name = "numUpDown_Green";
            this.numUpDown_Green.Size = new System.Drawing.Size(88, 20);
            this.numUpDown_Green.TabIndex = 5;
            // 
            // numUpDown_Black
            // 
            this.numUpDown_Black.Location = new System.Drawing.Point(99, 93);
            this.numUpDown_Black.Name = "numUpDown_Black";
            this.numUpDown_Black.Size = new System.Drawing.Size(88, 20);
            this.numUpDown_Black.TabIndex = 6;
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(96, 25);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(69, 13);
            this.lbl_Number.TabIndex = 7;
            this.lbl_Number.Text = "Количество:";
            // 
            // dTP_DateBeginning
            // 
            this.dTP_DateBeginning.Location = new System.Drawing.Point(12, 46);
            this.dTP_DateBeginning.Name = "dTP_DateBeginning";
            this.dTP_DateBeginning.Size = new System.Drawing.Size(137, 20);
            this.dTP_DateBeginning.TabIndex = 8;
            // 
            // lbl_DateBeginning
            // 
            this.lbl_DateBeginning.AutoSize = true;
            this.lbl_DateBeginning.Location = new System.Drawing.Point(9, 27);
            this.lbl_DateBeginning.Name = "lbl_DateBeginning";
            this.lbl_DateBeginning.Size = new System.Drawing.Size(74, 13);
            this.lbl_DateBeginning.TabIndex = 9;
            this.lbl_DateBeginning.Text = "Дата начала:";
            // 
            // lbl_DateExpiration
            // 
            this.lbl_DateExpiration.AutoSize = true;
            this.lbl_DateExpiration.Location = new System.Drawing.Point(182, 27);
            this.lbl_DateExpiration.Name = "lbl_DateExpiration";
            this.lbl_DateExpiration.Size = new System.Drawing.Size(92, 13);
            this.lbl_DateExpiration.TabIndex = 10;
            this.lbl_DateExpiration.Text = "Дата окончания:";
            // 
            // dTP_DateExpiration
            // 
            this.dTP_DateExpiration.Location = new System.Drawing.Point(185, 46);
            this.dTP_DateExpiration.Name = "dTP_DateExpiration";
            this.dTP_DateExpiration.Size = new System.Drawing.Size(137, 20);
            this.dTP_DateExpiration.TabIndex = 11;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(197, 333);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 12;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(198, 25);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(36, 13);
            this.lbl_Price.TabIndex = 14;
            this.lbl_Price.Text = "Цена:";
            // 
            // lbl_PriceRed
            // 
            this.lbl_PriceRed.AutoSize = true;
            this.lbl_PriceRed.Location = new System.Drawing.Point(198, 49);
            this.lbl_PriceRed.Name = "lbl_PriceRed";
            this.lbl_PriceRed.Size = new System.Drawing.Size(10, 13);
            this.lbl_PriceRed.TabIndex = 15;
            this.lbl_PriceRed.Text = "-";
            // 
            // lbl_PriceGreen
            // 
            this.lbl_PriceGreen.AutoSize = true;
            this.lbl_PriceGreen.Location = new System.Drawing.Point(198, 74);
            this.lbl_PriceGreen.Name = "lbl_PriceGreen";
            this.lbl_PriceGreen.Size = new System.Drawing.Size(10, 13);
            this.lbl_PriceGreen.TabIndex = 16;
            this.lbl_PriceGreen.Text = "-";
            // 
            // lbl_PriceBlack
            // 
            this.lbl_PriceBlack.AutoSize = true;
            this.lbl_PriceBlack.Location = new System.Drawing.Point(198, 97);
            this.lbl_PriceBlack.Name = "lbl_PriceBlack";
            this.lbl_PriceBlack.Size = new System.Drawing.Size(10, 13);
            this.lbl_PriceBlack.TabIndex = 17;
            this.lbl_PriceBlack.Text = "-";
            // 
            // lbl_InStockBlack
            // 
            this.lbl_InStockBlack.AutoSize = true;
            this.lbl_InStockBlack.Location = new System.Drawing.Point(264, 97);
            this.lbl_InStockBlack.Name = "lbl_InStockBlack";
            this.lbl_InStockBlack.Size = new System.Drawing.Size(10, 13);
            this.lbl_InStockBlack.TabIndex = 21;
            this.lbl_InStockBlack.Text = "-";
            // 
            // lbl_InStockGreen
            // 
            this.lbl_InStockGreen.AutoSize = true;
            this.lbl_InStockGreen.Location = new System.Drawing.Point(264, 74);
            this.lbl_InStockGreen.Name = "lbl_InStockGreen";
            this.lbl_InStockGreen.Size = new System.Drawing.Size(10, 13);
            this.lbl_InStockGreen.TabIndex = 20;
            this.lbl_InStockGreen.Text = "-";
            // 
            // lbl_InStockRed
            // 
            this.lbl_InStockRed.AutoSize = true;
            this.lbl_InStockRed.Location = new System.Drawing.Point(264, 49);
            this.lbl_InStockRed.Name = "lbl_InStockRed";
            this.lbl_InStockRed.Size = new System.Drawing.Size(10, 13);
            this.lbl_InStockRed.TabIndex = 19;
            this.lbl_InStockRed.Text = "-";
            // 
            // lbl_InStock
            // 
            this.lbl_InStock.AutoSize = true;
            this.lbl_InStock.Location = new System.Drawing.Point(264, 25);
            this.lbl_InStock.Name = "lbl_InStock";
            this.lbl_InStock.Size = new System.Drawing.Size(61, 13);
            this.lbl_InStock.TabIndex = 18;
            this.lbl_InStock.Text = "В наличии:";
            // 
            // gBx_Term
            // 
            this.gBx_Term.Controls.Add(this.lbl_DateBeginning);
            this.gBx_Term.Controls.Add(this.dTP_DateBeginning);
            this.gBx_Term.Controls.Add(this.lbl_DateExpiration);
            this.gBx_Term.Controls.Add(this.dTP_DateExpiration);
            this.gBx_Term.Location = new System.Drawing.Point(12, 142);
            this.gBx_Term.Name = "gBx_Term";
            this.gBx_Term.Size = new System.Drawing.Size(338, 81);
            this.gBx_Term.TabIndex = 22;
            this.gBx_Term.TabStop = false;
            this.gBx_Term.Text = "Срок";
            // 
            // gBx_Main
            // 
            this.gBx_Main.Controls.Add(this.lbl_Color);
            this.gBx_Main.Controls.Add(this.cBx_Red);
            this.gBx_Main.Controls.Add(this.lbl_InStockBlack);
            this.gBx_Main.Controls.Add(this.cBx_Green);
            this.gBx_Main.Controls.Add(this.lbl_InStockGreen);
            this.gBx_Main.Controls.Add(this.cBx_Black);
            this.gBx_Main.Controls.Add(this.lbl_InStockRed);
            this.gBx_Main.Controls.Add(this.numUpDown_Red);
            this.gBx_Main.Controls.Add(this.lbl_InStock);
            this.gBx_Main.Controls.Add(this.numUpDown_Green);
            this.gBx_Main.Controls.Add(this.lbl_PriceBlack);
            this.gBx_Main.Controls.Add(this.numUpDown_Black);
            this.gBx_Main.Controls.Add(this.lbl_PriceGreen);
            this.gBx_Main.Controls.Add(this.lbl_Number);
            this.gBx_Main.Controls.Add(this.lbl_PriceRed);
            this.gBx_Main.Controls.Add(this.lbl_Price);
            this.gBx_Main.Location = new System.Drawing.Point(12, 12);
            this.gBx_Main.Name = "gBx_Main";
            this.gBx_Main.Size = new System.Drawing.Size(338, 124);
            this.gBx_Main.TabIndex = 23;
            this.gBx_Main.TabStop = false;
            this.gBx_Main.Text = "Основное";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(278, 333);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 24;
            this.btn_Close.Text = "Отмена";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // gBx_Preliminary
            // 
            this.gBx_Preliminary.Controls.Add(this.btn_UpdatePreliminary);
            this.gBx_Preliminary.Controls.Add(this.lbl_Price_Result_Value);
            this.gBx_Preliminary.Controls.Add(this.lbl_Price_Result);
            this.gBx_Preliminary.Controls.Add(this.lbl_All_Days_Value);
            this.gBx_Preliminary.Controls.Add(this.lbl_All_Days);
            this.gBx_Preliminary.Controls.Add(this.lbl_Number_All_Duck_Value);
            this.gBx_Preliminary.Controls.Add(this.lbl_Number_All_Duck);
            this.gBx_Preliminary.Location = new System.Drawing.Point(12, 229);
            this.gBx_Preliminary.Name = "gBx_Preliminary";
            this.gBx_Preliminary.Size = new System.Drawing.Size(338, 98);
            this.gBx_Preliminary.TabIndex = 25;
            this.gBx_Preliminary.TabStop = false;
            this.gBx_Preliminary.Text = "Предварительный итог";
            // 
            // btn_UpdatePreliminary
            // 
            this.btn_UpdatePreliminary.Image = global::RentOfDucks.Properties.Resources.Update_l_l;
            this.btn_UpdatePreliminary.Location = new System.Drawing.Point(307, 13);
            this.btn_UpdatePreliminary.Name = "btn_UpdatePreliminary";
            this.btn_UpdatePreliminary.Size = new System.Drawing.Size(25, 25);
            this.btn_UpdatePreliminary.TabIndex = 25;
            this.btn_UpdatePreliminary.UseVisualStyleBackColor = true;
            this.btn_UpdatePreliminary.Click += new System.EventHandler(this.btn_UpdatePreliminary_Click);
            // 
            // lbl_Price_Result_Value
            // 
            this.lbl_Price_Result_Value.AutoSize = true;
            this.lbl_Price_Result_Value.Location = new System.Drawing.Point(120, 73);
            this.lbl_Price_Result_Value.Name = "lbl_Price_Result_Value";
            this.lbl_Price_Result_Value.Size = new System.Drawing.Size(10, 13);
            this.lbl_Price_Result_Value.TabIndex = 24;
            this.lbl_Price_Result_Value.Text = "-";
            // 
            // lbl_Price_Result
            // 
            this.lbl_Price_Result.AutoSize = true;
            this.lbl_Price_Result.Location = new System.Drawing.Point(9, 71);
            this.lbl_Price_Result.Name = "lbl_Price_Result";
            this.lbl_Price_Result.Size = new System.Drawing.Size(44, 13);
            this.lbl_Price_Result.TabIndex = 2;
            this.lbl_Price_Result.Text = "Сумма:";
            // 
            // lbl_All_Days_Value
            // 
            this.lbl_All_Days_Value.AutoSize = true;
            this.lbl_All_Days_Value.Location = new System.Drawing.Point(120, 50);
            this.lbl_All_Days_Value.Name = "lbl_All_Days_Value";
            this.lbl_All_Days_Value.Size = new System.Drawing.Size(10, 13);
            this.lbl_All_Days_Value.TabIndex = 23;
            this.lbl_All_Days_Value.Text = "-";
            // 
            // lbl_All_Days
            // 
            this.lbl_All_Days.AutoSize = true;
            this.lbl_All_Days.Location = new System.Drawing.Point(9, 48);
            this.lbl_All_Days.Name = "lbl_All_Days";
            this.lbl_All_Days.Size = new System.Drawing.Size(96, 13);
            this.lbl_All_Days.TabIndex = 1;
            this.lbl_All_Days.Text = "Количество дней:";
            // 
            // lbl_Number_All_Duck_Value
            // 
            this.lbl_Number_All_Duck_Value.AutoSize = true;
            this.lbl_Number_All_Duck_Value.Location = new System.Drawing.Point(120, 25);
            this.lbl_Number_All_Duck_Value.Name = "lbl_Number_All_Duck_Value";
            this.lbl_Number_All_Duck_Value.Size = new System.Drawing.Size(10, 13);
            this.lbl_Number_All_Duck_Value.TabIndex = 22;
            this.lbl_Number_All_Duck_Value.Text = "-";
            // 
            // lbl_Number_All_Duck
            // 
            this.lbl_Number_All_Duck.AutoSize = true;
            this.lbl_Number_All_Duck.Location = new System.Drawing.Point(9, 25);
            this.lbl_Number_All_Duck.Name = "lbl_Number_All_Duck";
            this.lbl_Number_All_Duck.Size = new System.Drawing.Size(105, 13);
            this.lbl_Number_All_Duck.TabIndex = 0;
            this.lbl_Number_All_Duck.Text = "Количество уточек:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.gBx_Preliminary);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.gBx_Main);
            this.Controls.Add(this.gBx_Term);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Black)).EndInit();
            this.gBx_Term.ResumeLayout(false);
            this.gBx_Term.PerformLayout();
            this.gBx_Main.ResumeLayout(false);
            this.gBx_Main.PerformLayout();
            this.gBx_Preliminary.ResumeLayout(false);
            this.gBx_Preliminary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cBx_Red;
        private System.Windows.Forms.CheckBox cBx_Green;
        private System.Windows.Forms.CheckBox cBx_Black;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.NumericUpDown numUpDown_Red;
        private System.Windows.Forms.NumericUpDown numUpDown_Green;
        private System.Windows.Forms.NumericUpDown numUpDown_Black;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.DateTimePicker dTP_DateBeginning;
        private System.Windows.Forms.Label lbl_DateBeginning;
        private System.Windows.Forms.Label lbl_DateExpiration;
        private System.Windows.Forms.DateTimePicker dTP_DateExpiration;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_PriceRed;
        private System.Windows.Forms.Label lbl_PriceGreen;
        private System.Windows.Forms.Label lbl_PriceBlack;
        private System.Windows.Forms.Label lbl_InStockBlack;
        private System.Windows.Forms.Label lbl_InStockGreen;
        private System.Windows.Forms.Label lbl_InStockRed;
        private System.Windows.Forms.Label lbl_InStock;
        private System.Windows.Forms.GroupBox gBx_Term;
        private System.Windows.Forms.GroupBox gBx_Main;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox gBx_Preliminary;
        private System.Windows.Forms.Label lbl_Price_Result_Value;
        private System.Windows.Forms.Label lbl_Price_Result;
        private System.Windows.Forms.Label lbl_All_Days_Value;
        private System.Windows.Forms.Label lbl_All_Days;
        private System.Windows.Forms.Label lbl_Number_All_Duck_Value;
        private System.Windows.Forms.Label lbl_Number_All_Duck;
        private System.Windows.Forms.Button btn_UpdatePreliminary;
    }
}

