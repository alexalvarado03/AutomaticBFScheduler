namespace BFConfigApp
{
    partial class ConfigForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nextBtn = new Button();
            smallSilverTB = new TextBox();
            caseSizeLbl = new Label();
            smallSilverLbl = new Label();
            smallRainbowLbl = new Label();
            smallRainbowTB = new TextBox();
            mediumLbl = new Label();
            mediumTB = new TextBox();
            mediumPebbleLbl = new Label();
            mediumPebbleTB = new TextBox();
            amountLbl = new Label();
            largeLbl = new Label();
            largeTB = new TextBox();
            caseErrorLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            smallInfraRadioBtn = new RadioButton();
            largeInfraRadioBtn = new RadioButton();
            customRadioBtn = new RadioButton();
            infraRadioBtnHolder = new GroupBox();
            linenRadioBtnHolder = new GroupBox();
            numberLinensLbl = new Label();
            numLinenComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            tableTopFairCheckBox = new CheckBox();
            minMaxCashRangeLbl = new Label();
            minRangeLbl = new Label();
            maxRangeLbl = new Label();
            minRangeTB = new TextBox();
            maxRangeTB = new TextBox();
            dollarSignLbl1 = new Label();
            dollarSignLbl2 = new Label();
            cashRangeErrorLbl = new Label();
            completeFormLbl = new Label();
            BackBtn = new Button();
            infraRadioBtnHolder.SuspendLayout();
            linenRadioBtnHolder.SuspendLayout();
            SuspendLayout();
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(695, 654);
            nextBtn.Margin = new Padding(4);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(275, 29);
            nextBtn.TabIndex = 0;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // smallSilverTB
            // 
            smallSilverTB.Location = new Point(396, 136);
            smallSilverTB.Margin = new Padding(4);
            smallSilverTB.Name = "smallSilverTB";
            smallSilverTB.Size = new Size(148, 26);
            smallSilverTB.TabIndex = 1;
            smallSilverTB.Text = "0";
            smallSilverTB.TextChanged += CaseTextBox_TextChanged;
            // 
            // caseSizeLbl
            // 
            caseSizeLbl.AutoSize = true;
            caseSizeLbl.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            caseSizeLbl.Location = new Point(172, 65);
            caseSizeLbl.Margin = new Padding(4, 0, 4, 0);
            caseSizeLbl.Name = "caseSizeLbl";
            caseSizeLbl.Size = new Size(120, 26);
            caseSizeLbl.TabIndex = 2;
            caseSizeLbl.Text = "Case sizes:";
            // 
            // smallSilverLbl
            // 
            smallSilverLbl.AutoSize = true;
            smallSilverLbl.Font = new Font("Times New Roman", 12F);
            smallSilverLbl.Location = new Point(166, 141);
            smallSilverLbl.Margin = new Padding(4, 0, 4, 0);
            smallSilverLbl.Name = "smallSilverLbl";
            smallSilverLbl.Size = new Size(83, 19);
            smallSilverLbl.TabIndex = 3;
            smallSilverLbl.Text = "Small Silver:";
            // 
            // smallRainbowLbl
            // 
            smallRainbowLbl.AutoSize = true;
            smallRainbowLbl.Font = new Font("Times New Roman", 12F);
            smallRainbowLbl.Location = new Point(166, 227);
            smallRainbowLbl.Margin = new Padding(4, 0, 4, 0);
            smallRainbowLbl.Name = "smallRainbowLbl";
            smallRainbowLbl.Size = new Size(103, 19);
            smallRainbowLbl.TabIndex = 5;
            smallRainbowLbl.Text = "Small Rainbow:";
            // 
            // smallRainbowTB
            // 
            smallRainbowTB.Location = new Point(396, 222);
            smallRainbowTB.Margin = new Padding(4);
            smallRainbowTB.Name = "smallRainbowTB";
            smallRainbowTB.Size = new Size(148, 26);
            smallRainbowTB.TabIndex = 4;
            smallRainbowTB.Text = "0";
            smallRainbowTB.TextChanged += CaseTextBox_TextChanged;
            // 
            // mediumLbl
            // 
            mediumLbl.AutoSize = true;
            mediumLbl.Font = new Font("Times New Roman", 12F);
            mediumLbl.Location = new Point(166, 311);
            mediumLbl.Margin = new Padding(4, 0, 4, 0);
            mediumLbl.Name = "mediumLbl";
            mediumLbl.Size = new Size(62, 19);
            mediumLbl.TabIndex = 7;
            mediumLbl.Text = "Medium:";
            // 
            // mediumTB
            // 
            mediumTB.Location = new Point(396, 306);
            mediumTB.Margin = new Padding(4);
            mediumTB.Name = "mediumTB";
            mediumTB.Size = new Size(148, 26);
            mediumTB.TabIndex = 6;
            mediumTB.Text = "0";
            mediumTB.TextChanged += CaseTextBox_TextChanged;
            // 
            // mediumPebbleLbl
            // 
            mediumPebbleLbl.AutoSize = true;
            mediumPebbleLbl.Font = new Font("Times New Roman", 12F);
            mediumPebbleLbl.Location = new Point(166, 394);
            mediumPebbleLbl.Margin = new Padding(4, 0, 4, 0);
            mediumPebbleLbl.Name = "mediumPebbleLbl";
            mediumPebbleLbl.Size = new Size(136, 19);
            mediumPebbleLbl.TabIndex = 9;
            mediumPebbleLbl.Text = "Medium Pebble Top:";
            // 
            // mediumPebbleTB
            // 
            mediumPebbleTB.Location = new Point(396, 394);
            mediumPebbleTB.Margin = new Padding(4);
            mediumPebbleTB.Name = "mediumPebbleTB";
            mediumPebbleTB.Size = new Size(148, 26);
            mediumPebbleTB.TabIndex = 8;
            mediumPebbleTB.Text = "0";
            mediumPebbleTB.TextChanged += CaseTextBox_TextChanged;
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            amountLbl.Location = new Point(396, 65);
            amountLbl.Margin = new Padding(4, 0, 4, 0);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(102, 26);
            amountLbl.TabIndex = 10;
            amountLbl.Text = "Amount:";
            // 
            // largeLbl
            // 
            largeLbl.AutoSize = true;
            largeLbl.Font = new Font("Times New Roman", 12F);
            largeLbl.Location = new Point(166, 489);
            largeLbl.Margin = new Padding(4, 0, 4, 0);
            largeLbl.Name = "largeLbl";
            largeLbl.Size = new Size(47, 19);
            largeLbl.TabIndex = 12;
            largeLbl.Text = "Large:";
            // 
            // largeTB
            // 
            largeTB.Location = new Point(396, 489);
            largeTB.Margin = new Padding(4);
            largeTB.Name = "largeTB";
            largeTB.Size = new Size(148, 26);
            largeTB.TabIndex = 11;
            largeTB.Text = "0";
            largeTB.TextChanged += CaseTextBox_TextChanged;
            // 
            // caseErrorLbl
            // 
            caseErrorLbl.AutoSize = true;
            caseErrorLbl.ForeColor = SystemColors.ControlText;
            caseErrorLbl.Location = new Point(256, 637);
            caseErrorLbl.Margin = new Padding(4, 0, 4, 0);
            caseErrorLbl.Name = "caseErrorLbl";
            caseErrorLbl.Size = new Size(0, 19);
            caseErrorLbl.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(717, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label2.Location = new Point(716, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 26);
            label2.TabIndex = 15;
            label2.Text = "Select Infrastructure:";
            // 
            // smallInfraRadioBtn
            // 
            smallInfraRadioBtn.AutoSize = true;
            smallInfraRadioBtn.Checked = true;
            smallInfraRadioBtn.Location = new Point(45, 29);
            smallInfraRadioBtn.Name = "smallInfraRadioBtn";
            smallInfraRadioBtn.Size = new Size(144, 23);
            smallInfraRadioBtn.TabIndex = 16;
            smallInfraRadioBtn.TabStop = true;
            smallInfraRadioBtn.Text = "Small Infrastructure";
            smallInfraRadioBtn.UseVisualStyleBackColor = true;
            // 
            // largeInfraRadioBtn
            // 
            largeInfraRadioBtn.AutoSize = true;
            largeInfraRadioBtn.Location = new Point(45, 85);
            largeInfraRadioBtn.Name = "largeInfraRadioBtn";
            largeInfraRadioBtn.Size = new Size(146, 23);
            largeInfraRadioBtn.TabIndex = 17;
            largeInfraRadioBtn.Text = "Large Infrastructure";
            largeInfraRadioBtn.UseVisualStyleBackColor = true;
            // 
            // customRadioBtn
            // 
            customRadioBtn.AutoSize = true;
            customRadioBtn.Location = new Point(45, 143);
            customRadioBtn.Name = "customRadioBtn";
            customRadioBtn.Size = new Size(158, 23);
            customRadioBtn.TabIndex = 18;
            customRadioBtn.Text = "Custom Infrastructure";
            customRadioBtn.UseVisualStyleBackColor = true;
            // 
            // infraRadioBtnHolder
            // 
            infraRadioBtnHolder.Controls.Add(largeInfraRadioBtn);
            infraRadioBtnHolder.Controls.Add(customRadioBtn);
            infraRadioBtnHolder.Controls.Add(smallInfraRadioBtn);
            infraRadioBtnHolder.Location = new Point(717, 110);
            infraRadioBtnHolder.Name = "infraRadioBtnHolder";
            infraRadioBtnHolder.Size = new Size(237, 196);
            infraRadioBtnHolder.TabIndex = 19;
            infraRadioBtnHolder.TabStop = false;
            // 
            // linenRadioBtnHolder
            // 
            linenRadioBtnHolder.Controls.Add(numberLinensLbl);
            linenRadioBtnHolder.Controls.Add(numLinenComboBox);
            linenRadioBtnHolder.Location = new Point(717, 373);
            linenRadioBtnHolder.Name = "linenRadioBtnHolder";
            linenRadioBtnHolder.Size = new Size(237, 142);
            linenRadioBtnHolder.TabIndex = 22;
            linenRadioBtnHolder.TabStop = false;
            // 
            // numberLinensLbl
            // 
            numberLinensLbl.AutoSize = true;
            numberLinensLbl.Font = new Font("Times New Roman", 12F);
            numberLinensLbl.Location = new Point(45, 37);
            numberLinensLbl.Margin = new Padding(4, 0, 4, 0);
            numberLinensLbl.Name = "numberLinensLbl";
            numberLinensLbl.Size = new Size(121, 19);
            numberLinensLbl.TabIndex = 23;
            numberLinensLbl.Text = "Number of Linens:";
            // 
            // numLinenComboBox
            // 
            numLinenComboBox.FormattingEnabled = true;
            numLinenComboBox.Items.AddRange(new object[] { "6", "10", ">10" });
            numLinenComboBox.Location = new Point(45, 86);
            numLinenComboBox.Name = "numLinenComboBox";
            numLinenComboBox.Size = new Size(121, 27);
            numLinenComboBox.TabIndex = 19;
            numLinenComboBox.Text = "--Select--";
            numLinenComboBox.SelectedIndexChanged += numLinenComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label3.Location = new Point(716, 328);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 26);
            label3.TabIndex = 21;
            label3.Text = "Select Linens:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(717, 334);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 20;
            label4.Text = "Select Linens:";
            // 
            // tableTopFairCheckBox
            // 
            tableTopFairCheckBox.AutoSize = true;
            tableTopFairCheckBox.Location = new Point(256, 563);
            tableTopFairCheckBox.Name = "tableTopFairCheckBox";
            tableTopFairCheckBox.Size = new Size(117, 23);
            tableTopFairCheckBox.TabIndex = 23;
            tableTopFairCheckBox.Text = "Table Top Fair";
            tableTopFairCheckBox.UseVisualStyleBackColor = true;
            tableTopFairCheckBox.CheckedChanged += TableTopFairCheckBox_CheckedChanged;
            // 
            // minMaxCashRangeLbl
            // 
            minMaxCashRangeLbl.AutoSize = true;
            minMaxCashRangeLbl.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minMaxCashRangeLbl.Location = new Point(1149, 65);
            minMaxCashRangeLbl.Name = "minMaxCashRangeLbl";
            minMaxCashRangeLbl.Size = new Size(245, 26);
            minMaxCashRangeLbl.TabIndex = 24;
            minMaxCashRangeLbl.Text = "Min/Max Cash Range:";
            // 
            // minRangeLbl
            // 
            minRangeLbl.AutoSize = true;
            minRangeLbl.Font = new Font("Times New Roman", 12F);
            minRangeLbl.Location = new Point(1149, 143);
            minRangeLbl.Margin = new Padding(4, 0, 4, 0);
            minRangeLbl.Name = "minRangeLbl";
            minRangeLbl.Size = new Size(78, 19);
            minRangeLbl.TabIndex = 25;
            minRangeLbl.Text = "Min Range:";
            // 
            // maxRangeLbl
            // 
            maxRangeLbl.AutoSize = true;
            maxRangeLbl.Font = new Font("Times New Roman", 12F);
            maxRangeLbl.Location = new Point(1149, 199);
            maxRangeLbl.Margin = new Padding(4, 0, 4, 0);
            maxRangeLbl.Name = "maxRangeLbl";
            maxRangeLbl.Size = new Size(82, 19);
            maxRangeLbl.TabIndex = 26;
            maxRangeLbl.Text = "Max Range:";
            // 
            // minRangeTB
            // 
            minRangeTB.Location = new Point(1280, 140);
            minRangeTB.Name = "minRangeTB";
            minRangeTB.Size = new Size(143, 26);
            minRangeTB.TabIndex = 27;
            minRangeTB.Text = "0";
            minRangeTB.TextChanged += CashRange_TextChanged;
            // 
            // maxRangeTB
            // 
            maxRangeTB.Location = new Point(1280, 196);
            maxRangeTB.Name = "maxRangeTB";
            maxRangeTB.Size = new Size(143, 26);
            maxRangeTB.TabIndex = 28;
            maxRangeTB.Text = "0";
            maxRangeTB.TextChanged += CashRange_TextChanged;
            // 
            // dollarSignLbl1
            // 
            dollarSignLbl1.AutoSize = true;
            dollarSignLbl1.Location = new Point(1257, 143);
            dollarSignLbl1.Name = "dollarSignLbl1";
            dollarSignLbl1.Size = new Size(17, 19);
            dollarSignLbl1.TabIndex = 29;
            dollarSignLbl1.Text = "$";
            // 
            // dollarSignLbl2
            // 
            dollarSignLbl2.AutoSize = true;
            dollarSignLbl2.Location = new Point(1257, 199);
            dollarSignLbl2.Name = "dollarSignLbl2";
            dollarSignLbl2.Size = new Size(17, 19);
            dollarSignLbl2.TabIndex = 30;
            dollarSignLbl2.Text = "$";
            // 
            // cashRangeErrorLbl
            // 
            cashRangeErrorLbl.AutoSize = true;
            cashRangeErrorLbl.Location = new Point(1231, 266);
            cashRangeErrorLbl.Name = "cashRangeErrorLbl";
            cashRangeErrorLbl.Size = new Size(0, 19);
            cashRangeErrorLbl.TabIndex = 31;
            // 
            // completeFormLbl
            // 
            completeFormLbl.AutoSize = true;
            completeFormLbl.Location = new Point(643, 699);
            completeFormLbl.Name = "completeFormLbl";
            completeFormLbl.Size = new Size(0, 19);
            completeFormLbl.TabIndex = 32;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 33;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 811);
            Controls.Add(BackBtn);
            Controls.Add(completeFormLbl);
            Controls.Add(cashRangeErrorLbl);
            Controls.Add(dollarSignLbl2);
            Controls.Add(dollarSignLbl1);
            Controls.Add(maxRangeTB);
            Controls.Add(minRangeTB);
            Controls.Add(maxRangeLbl);
            Controls.Add(minRangeLbl);
            Controls.Add(minMaxCashRangeLbl);
            Controls.Add(tableTopFairCheckBox);
            Controls.Add(linenRadioBtnHolder);
            Controls.Add(label3);
            Controls.Add(infraRadioBtnHolder);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(caseErrorLbl);
            Controls.Add(largeLbl);
            Controls.Add(largeTB);
            Controls.Add(amountLbl);
            Controls.Add(mediumPebbleLbl);
            Controls.Add(mediumPebbleTB);
            Controls.Add(mediumLbl);
            Controls.Add(mediumTB);
            Controls.Add(smallRainbowLbl);
            Controls.Add(smallRainbowTB);
            Controls.Add(smallSilverLbl);
            Controls.Add(caseSizeLbl);
            Controls.Add(smallSilverTB);
            Controls.Add(nextBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ConfigForm";
            Text = "ConfigForm";
            Load += ConfigForm_Load;
            infraRadioBtnHolder.ResumeLayout(false);
            infraRadioBtnHolder.PerformLayout();
            linenRadioBtnHolder.ResumeLayout(false);
            linenRadioBtnHolder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextBtn;
        private TextBox smallSilverTB;
        private Label caseSizeLbl;
        private Label smallSilverLbl;
        private Label smallRainbowLbl;
        private TextBox smallRainbowTB;
        private Label mediumLbl;
        private TextBox mediumTB;
        private Label mediumPebbleLbl;
        private TextBox mediumPebbleTB;
        private Label amountLbl;
        private Label largeLbl;
        private TextBox largeTB;
        private Label caseErrorLbl;
        private Label label1;
        private Label label2;
        private RadioButton smallInfraRadioBtn;
        private RadioButton largeInfraRadioBtn;
        private RadioButton customRadioBtn;
        private GroupBox infraRadioBtnHolder;
        private GroupBox linenRadioBtnHolder;
        private Label label3;
        private Label label4;
        private ComboBox numLinenComboBox;
        private Label numberLinensLbl;
        private CheckBox tableTopFairCheckBox;
        private Label minMaxCashRangeLbl;
        private Label minRangeLbl;
        private Label maxRangeLbl;
        private TextBox minRangeTB;
        private TextBox maxRangeTB;
        private Label dollarSignLbl1;
        private Label dollarSignLbl2;
        private Label cashRangeErrorLbl;
        private Label completeFormLbl;
        private Button BackBtn;
    }
}
