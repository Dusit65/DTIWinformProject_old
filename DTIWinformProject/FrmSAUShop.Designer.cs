﻿namespace DTIWinformProject
{
    partial class FrmSAUShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSAUShop));
            this.HeadLabel = new System.Windows.Forms.Label();
            this.checkBoxPen = new System.Windows.Forms.CheckBox();
            this.labelProductList = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.TBPen = new System.Windows.Forms.TextBox();
            this.labelTotalPen = new System.Windows.Forms.Label();
            this.labelBaht1 = new System.Windows.Forms.Label();
            this.labelBaht3 = new System.Windows.Forms.Label();
            this.labelTotalEraser = new System.Windows.Forms.Label();
            this.TBEraser = new System.Windows.Forms.TextBox();
            this.checkBoxEraser = new System.Windows.Forms.CheckBox();
            this.labelBaht2 = new System.Windows.Forms.Label();
            this.labelTotalPencil = new System.Windows.Forms.Label();
            this.TBPencil = new System.Windows.Forms.TextBox();
            this.checkBoxPencil = new System.Windows.Forms.CheckBox();
            this.labelBaht4 = new System.Windows.Forms.Label();
            this.labelTotalRuler = new System.Windows.Forms.Label();
            this.TBRuler = new System.Windows.Forms.TextBox();
            this.checkBoxRuler = new System.Windows.Forms.CheckBox();
            this.labelBaht5 = new System.Windows.Forms.Label();
            this.labelTotalNbook = new System.Windows.Forms.Label();
            this.TBNbook = new System.Windows.Forms.TextBox();
            this.checkBoxNbook = new System.Windows.Forms.CheckBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTMainMenu = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLabel
            // 
            this.HeadLabel.BackColor = System.Drawing.Color.Yellow;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Blue;
            this.HeadLabel.Location = new System.Drawing.Point(34, 7);
            this.HeadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(466, 84);
            this.HeadLabel.TabIndex = 4;
            this.HeadLabel.Text = "SAU Shop";
            this.HeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPen
            // 
            this.checkBoxPen.AutoSize = true;
            this.checkBoxPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPen.Location = new System.Drawing.Point(46, 157);
            this.checkBoxPen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPen.Name = "checkBoxPen";
            this.checkBoxPen.Size = new System.Drawing.Size(150, 24);
            this.checkBoxPen.TabIndex = 6;
            this.checkBoxPen.Text = "ปากกา 5 บาท / ด้าม";
            this.checkBoxPen.UseVisualStyleBackColor = true;
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductList.Location = new System.Drawing.Point(85, 114);
            this.labelProductList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(97, 20);
            this.labelProductList.TabIndex = 7;
            this.labelProductList.Text = "รายการสินค้า";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BTCalculate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(80, 401);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(603, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DTIWinformProject.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(448, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 64);
            this.button1.TabIndex = 32;
            this.button1.Text = "ยกเลิก";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BTCalculate
            // 
            this.BTCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCalculate.Image = global::DTIWinformProject.Properties.Resources.calculator2;
            this.BTCalculate.Location = new System.Drawing.Point(326, 12);
            this.BTCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTCalculate.Name = "BTCalculate";
            this.BTCalculate.Size = new System.Drawing.Size(94, 64);
            this.BTCalculate.TabIndex = 33;
            this.BTCalculate.Text = "คำนวณ";
            this.BTCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTCalculate.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "บาท";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "รวมเป็นเงินทั้งสิ้น";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(147, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 53);
            this.label1.TabIndex = 32;
            this.label1.Text = "0.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(379, 114);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(81, 20);
            this.labelTotalPrice.TabIndex = 9;
            this.labelTotalPrice.Text = "คิดเป็นเงิน";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(250, 114);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(54, 20);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "จำนวน";
            // 
            // TBPen
            // 
            this.TBPen.Location = new System.Drawing.Point(227, 162);
            this.TBPen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPen.Name = "TBPen";
            this.TBPen.Size = new System.Drawing.Size(97, 20);
            this.TBPen.TabIndex = 11;
            // 
            // labelTotalPen
            // 
            this.labelTotalPen.BackColor = System.Drawing.Color.Yellow;
            this.labelTotalPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPen.ForeColor = System.Drawing.Color.Red;
            this.labelTotalPen.Location = new System.Drawing.Point(370, 157);
            this.labelTotalPen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPen.Name = "labelTotalPen";
            this.labelTotalPen.Size = new System.Drawing.Size(94, 25);
            this.labelTotalPen.TabIndex = 12;
            this.labelTotalPen.Text = "0.00";
            this.labelTotalPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBaht1
            // 
            this.labelBaht1.AutoSize = true;
            this.labelBaht1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht1.Location = new System.Drawing.Point(510, 159);
            this.labelBaht1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht1.Name = "labelBaht1";
            this.labelBaht1.Size = new System.Drawing.Size(35, 20);
            this.labelBaht1.TabIndex = 13;
            this.labelBaht1.Text = "บาท";
            this.labelBaht1.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelBaht3
            // 
            this.labelBaht3.AutoSize = true;
            this.labelBaht3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht3.Location = new System.Drawing.Point(510, 246);
            this.labelBaht3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht3.Name = "labelBaht3";
            this.labelBaht3.Size = new System.Drawing.Size(35, 20);
            this.labelBaht3.TabIndex = 17;
            this.labelBaht3.Text = "บาท";
            // 
            // labelTotalEraser
            // 
            this.labelTotalEraser.BackColor = System.Drawing.Color.Yellow;
            this.labelTotalEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEraser.ForeColor = System.Drawing.Color.Red;
            this.labelTotalEraser.Location = new System.Drawing.Point(370, 244);
            this.labelTotalEraser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalEraser.Name = "labelTotalEraser";
            this.labelTotalEraser.Size = new System.Drawing.Size(94, 25);
            this.labelTotalEraser.TabIndex = 16;
            this.labelTotalEraser.Text = "0.00";
            this.labelTotalEraser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBEraser
            // 
            this.TBEraser.Location = new System.Drawing.Point(227, 248);
            this.TBEraser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBEraser.Name = "TBEraser";
            this.TBEraser.Size = new System.Drawing.Size(97, 20);
            this.TBEraser.TabIndex = 15;
            // 
            // checkBoxEraser
            // 
            this.checkBoxEraser.AutoSize = true;
            this.checkBoxEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEraser.Location = new System.Drawing.Point(46, 244);
            this.checkBoxEraser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxEraser.Name = "checkBoxEraser";
            this.checkBoxEraser.Size = new System.Drawing.Size(170, 24);
            this.checkBoxEraser.TabIndex = 14;
            this.checkBoxEraser.Text = "ยางลบ 2.50 บาท / ก้อน";
            this.checkBoxEraser.UseVisualStyleBackColor = true;
            // 
            // labelBaht2
            // 
            this.labelBaht2.AutoSize = true;
            this.labelBaht2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht2.Location = new System.Drawing.Point(510, 202);
            this.labelBaht2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht2.Name = "labelBaht2";
            this.labelBaht2.Size = new System.Drawing.Size(35, 20);
            this.labelBaht2.TabIndex = 21;
            this.labelBaht2.Text = "บาท";
            // 
            // labelTotalPencil
            // 
            this.labelTotalPencil.BackColor = System.Drawing.Color.Yellow;
            this.labelTotalPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPencil.ForeColor = System.Drawing.Color.Red;
            this.labelTotalPencil.Location = new System.Drawing.Point(370, 199);
            this.labelTotalPencil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPencil.Name = "labelTotalPencil";
            this.labelTotalPencil.Size = new System.Drawing.Size(94, 25);
            this.labelTotalPencil.TabIndex = 20;
            this.labelTotalPencil.Text = "0.00";
            this.labelTotalPencil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBPencil
            // 
            this.TBPencil.Location = new System.Drawing.Point(227, 205);
            this.TBPencil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPencil.Name = "TBPencil";
            this.TBPencil.Size = new System.Drawing.Size(97, 20);
            this.TBPencil.TabIndex = 19;
            // 
            // checkBoxPencil
            // 
            this.checkBoxPencil.AutoSize = true;
            this.checkBoxPencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPencil.Location = new System.Drawing.Point(46, 199);
            this.checkBoxPencil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPencil.Name = "checkBoxPencil";
            this.checkBoxPencil.Size = new System.Drawing.Size(165, 24);
            this.checkBoxPencil.TabIndex = 18;
            this.checkBoxPencil.Text = "ดินสอ 1.50 บาท / ด้าม";
            this.checkBoxPencil.UseVisualStyleBackColor = true;
            // 
            // labelBaht4
            // 
            this.labelBaht4.AutoSize = true;
            this.labelBaht4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht4.Location = new System.Drawing.Point(510, 288);
            this.labelBaht4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht4.Name = "labelBaht4";
            this.labelBaht4.Size = new System.Drawing.Size(35, 20);
            this.labelBaht4.TabIndex = 25;
            this.labelBaht4.Text = "บาท";
            // 
            // labelTotalRuler
            // 
            this.labelTotalRuler.BackColor = System.Drawing.Color.Yellow;
            this.labelTotalRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRuler.ForeColor = System.Drawing.Color.Red;
            this.labelTotalRuler.Location = new System.Drawing.Point(370, 285);
            this.labelTotalRuler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalRuler.Name = "labelTotalRuler";
            this.labelTotalRuler.Size = new System.Drawing.Size(94, 25);
            this.labelTotalRuler.TabIndex = 24;
            this.labelTotalRuler.Text = "0.00";
            this.labelTotalRuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBRuler
            // 
            this.TBRuler.Location = new System.Drawing.Point(227, 289);
            this.TBRuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBRuler.Name = "TBRuler";
            this.TBRuler.Size = new System.Drawing.Size(97, 20);
            this.TBRuler.TabIndex = 23;
            // 
            // checkBoxRuler
            // 
            this.checkBoxRuler.AutoSize = true;
            this.checkBoxRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRuler.Location = new System.Drawing.Point(46, 285);
            this.checkBoxRuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRuler.Name = "checkBoxRuler";
            this.checkBoxRuler.Size = new System.Drawing.Size(159, 24);
            this.checkBoxRuler.TabIndex = 22;
            this.checkBoxRuler.Text = "ไม้บรรทัด 2 บาท / อัน";
            this.checkBoxRuler.UseVisualStyleBackColor = true;
            // 
            // labelBaht5
            // 
            this.labelBaht5.AutoSize = true;
            this.labelBaht5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht5.Location = new System.Drawing.Point(510, 328);
            this.labelBaht5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaht5.Name = "labelBaht5";
            this.labelBaht5.Size = new System.Drawing.Size(35, 20);
            this.labelBaht5.TabIndex = 29;
            this.labelBaht5.Text = "บาท";
            // 
            // labelTotalNbook
            // 
            this.labelTotalNbook.BackColor = System.Drawing.Color.Yellow;
            this.labelTotalNbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalNbook.ForeColor = System.Drawing.Color.Red;
            this.labelTotalNbook.Location = new System.Drawing.Point(370, 329);
            this.labelTotalNbook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalNbook.Name = "labelTotalNbook";
            this.labelTotalNbook.Size = new System.Drawing.Size(94, 25);
            this.labelTotalNbook.TabIndex = 28;
            this.labelTotalNbook.Text = "0.00";
            this.labelTotalNbook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBNbook
            // 
            this.TBNbook.Location = new System.Drawing.Point(227, 332);
            this.TBNbook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNbook.Name = "TBNbook";
            this.TBNbook.Size = new System.Drawing.Size(97, 20);
            this.TBNbook.TabIndex = 27;
            // 
            // checkBoxNbook
            // 
            this.checkBoxNbook.AutoSize = true;
            this.checkBoxNbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNbook.Location = new System.Drawing.Point(46, 328);
            this.checkBoxNbook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxNbook.Name = "checkBoxNbook";
            this.checkBoxNbook.Size = new System.Drawing.Size(165, 24);
            this.checkBoxNbook.TabIndex = 26;
            this.checkBoxNbook.Text = "สมุด 10.25 บาท / เล่ม";
            this.checkBoxNbook.UseVisualStyleBackColor = true;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(100, 369);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(55, 20);
            this.labelDiscount.TabIndex = 30;
            this.labelDiscount.Text = "ส่วนลด";
            this.labelDiscount.Click += new System.EventHandler(this.labelDiscount_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5 %",
            "10 %",
            "15 %"});
            this.comboBox1.Location = new System.Drawing.Point(213, 369);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // BTMainMenu
            // 
            this.BTMainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BTMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMainMenu.Image = global::DTIWinformProject.Properties.Resources.pevious1;
            this.BTMainMenu.Location = new System.Drawing.Point(579, 7);
            this.BTMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTMainMenu.Name = "BTMainMenu";
            this.BTMainMenu.Size = new System.Drawing.Size(120, 84);
            this.BTMainMenu.TabIndex = 5;
            this.BTMainMenu.Text = "หน้าจอหลัก";
            this.BTMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTMainMenu.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 504);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "name?";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "datetime?";
            // 
            // FrmSAUShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 529);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelBaht5);
            this.Controls.Add(this.labelTotalNbook);
            this.Controls.Add(this.TBNbook);
            this.Controls.Add(this.checkBoxNbook);
            this.Controls.Add(this.labelBaht4);
            this.Controls.Add(this.labelTotalRuler);
            this.Controls.Add(this.TBRuler);
            this.Controls.Add(this.checkBoxRuler);
            this.Controls.Add(this.labelBaht2);
            this.Controls.Add(this.labelTotalPencil);
            this.Controls.Add(this.TBPencil);
            this.Controls.Add(this.checkBoxPencil);
            this.Controls.Add(this.labelBaht3);
            this.Controls.Add(this.labelTotalEraser);
            this.Controls.Add(this.TBEraser);
            this.Controls.Add(this.checkBoxEraser);
            this.Controls.Add(this.labelBaht1);
            this.Controls.Add(this.labelTotalPen);
            this.Controls.Add(this.TBPen);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.checkBoxPen);
            this.Controls.Add(this.BTMainMenu);
            this.Controls.Add(this.HeadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSAUShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอSAU Shop- DTI Soft V.1.0";
            this.Load += new System.EventHandler(this.FrmSAUShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button BTMainMenu;
        private System.Windows.Forms.CheckBox checkBoxPen;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox TBPen;
        private System.Windows.Forms.Label labelTotalPen;
        private System.Windows.Forms.Label labelBaht1;
        private System.Windows.Forms.Label labelBaht3;
        private System.Windows.Forms.Label labelTotalEraser;
        private System.Windows.Forms.TextBox TBEraser;
        private System.Windows.Forms.CheckBox checkBoxEraser;
        private System.Windows.Forms.Label labelBaht2;
        private System.Windows.Forms.Label labelTotalPencil;
        private System.Windows.Forms.TextBox TBPencil;
        private System.Windows.Forms.CheckBox checkBoxPencil;
        private System.Windows.Forms.Label labelBaht4;
        private System.Windows.Forms.Label labelTotalRuler;
        private System.Windows.Forms.TextBox TBRuler;
        private System.Windows.Forms.CheckBox checkBoxRuler;
        private System.Windows.Forms.Label labelBaht5;
        private System.Windows.Forms.Label labelTotalNbook;
        private System.Windows.Forms.TextBox TBNbook;
        private System.Windows.Forms.CheckBox checkBoxNbook;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTCalculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}