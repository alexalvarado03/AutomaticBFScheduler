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
            createConfigBtn = new Button();
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
            errorLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            smallInfraRadioBtn = new RadioButton();
            largeInfraRadioBtn = new RadioButton();
            customRadioBtn = new RadioButton();
            infraRadioBtnHolder = new GroupBox();
            linenRadioBtnHolder = new GroupBox();
            numberLinensLbl = new Label();
            numLinenComboBox = new ComboBox();
            longLinenRadioBtn = new RadioButton();
            customLinenRadioBtn = new RadioButton();
            standardLinenRadioBtn = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            tableTopFairCheckBox = new CheckBox();
            infraRadioBtnHolder.SuspendLayout();
            linenRadioBtnHolder.SuspendLayout();
            SuspendLayout();
            // 
            // createConfigBtn
            // 
            createConfigBtn.Location = new Point(582, 719);
            createConfigBtn.Margin = new Padding(4);
            createConfigBtn.Name = "createConfigBtn";
            createConfigBtn.Size = new Size(275, 29);
            createConfigBtn.TabIndex = 0;
            createConfigBtn.Text = "Create Config";
            createConfigBtn.UseVisualStyleBackColor = true;
            // 
            // smallSilverTB
            // 
            smallSilverTB.Location = new Point(277, 104);
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
            caseSizeLbl.Location = new Point(53, 33);
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
            smallSilverLbl.Location = new Point(47, 109);
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
            smallRainbowLbl.Location = new Point(47, 195);
            smallRainbowLbl.Margin = new Padding(4, 0, 4, 0);
            smallRainbowLbl.Name = "smallRainbowLbl";
            smallRainbowLbl.Size = new Size(103, 19);
            smallRainbowLbl.TabIndex = 5;
            smallRainbowLbl.Text = "Small Rainbow:";
            // 
            // smallRainbowTB
            // 
            smallRainbowTB.Location = new Point(277, 190);
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
            mediumLbl.Location = new Point(47, 279);
            mediumLbl.Margin = new Padding(4, 0, 4, 0);
            mediumLbl.Name = "mediumLbl";
            mediumLbl.Size = new Size(62, 19);
            mediumLbl.TabIndex = 7;
            mediumLbl.Text = "Medium:";
            // 
            // mediumTB
            // 
            mediumTB.Location = new Point(277, 274);
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
            mediumPebbleLbl.Location = new Point(47, 362);
            mediumPebbleLbl.Margin = new Padding(4, 0, 4, 0);
            mediumPebbleLbl.Name = "mediumPebbleLbl";
            mediumPebbleLbl.Size = new Size(136, 19);
            mediumPebbleLbl.TabIndex = 9;
            mediumPebbleLbl.Text = "Medium Pebble Top:";
            // 
            // mediumPebbleTB
            // 
            mediumPebbleTB.Location = new Point(277, 362);
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
            amountLbl.Location = new Point(277, 33);
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
            largeLbl.Location = new Point(47, 457);
            largeLbl.Margin = new Padding(4, 0, 4, 0);
            largeLbl.Name = "largeLbl";
            largeLbl.Size = new Size(47, 19);
            largeLbl.TabIndex = 12;
            largeLbl.Text = "Large:";
            // 
            // largeTB
            // 
            largeTB.Location = new Point(277, 457);
            largeTB.Margin = new Padding(4);
            largeTB.Name = "largeTB";
            largeTB.Size = new Size(148, 26);
            largeTB.TabIndex = 11;
            largeTB.Text = "0";
            largeTB.TextChanged += CaseTextBox_TextChanged;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.ForeColor = SystemColors.ControlText;
            errorLbl.Location = new Point(137, 605);
            errorLbl.Margin = new Padding(4, 0, 4, 0);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(0, 19);
            errorLbl.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(598, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label2.Location = new Point(597, 33);
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
            infraRadioBtnHolder.Location = new Point(598, 78);
            infraRadioBtnHolder.Name = "infraRadioBtnHolder";
            infraRadioBtnHolder.Size = new Size(237, 196);
            infraRadioBtnHolder.TabIndex = 19;
            infraRadioBtnHolder.TabStop = false;
            // 
            // linenRadioBtnHolder
            // 
            linenRadioBtnHolder.Controls.Add(numberLinensLbl);
            linenRadioBtnHolder.Controls.Add(numLinenComboBox);
            linenRadioBtnHolder.Controls.Add(longLinenRadioBtn);
            linenRadioBtnHolder.Controls.Add(customLinenRadioBtn);
            linenRadioBtnHolder.Controls.Add(standardLinenRadioBtn);
            linenRadioBtnHolder.Location = new Point(598, 341);
            linenRadioBtnHolder.Name = "linenRadioBtnHolder";
            linenRadioBtnHolder.Size = new Size(237, 293);
            linenRadioBtnHolder.TabIndex = 22;
            linenRadioBtnHolder.TabStop = false;
            // 
            // numberLinensLbl
            // 
            numberLinensLbl.AutoSize = true;
            numberLinensLbl.Font = new Font("Times New Roman", 12F);
            numberLinensLbl.Location = new Point(45, 194);
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
            numLinenComboBox.Location = new Point(45, 243);
            numLinenComboBox.Name = "numLinenComboBox";
            numLinenComboBox.Size = new Size(121, 27);
            numLinenComboBox.TabIndex = 19;
            numLinenComboBox.Text = "--Select--";
            // 
            // longLinenRadioBtn
            // 
            longLinenRadioBtn.AutoSize = true;
            longLinenRadioBtn.Location = new Point(45, 85);
            longLinenRadioBtn.Name = "longLinenRadioBtn";
            longLinenRadioBtn.Size = new Size(95, 23);
            longLinenRadioBtn.TabIndex = 17;
            longLinenRadioBtn.Text = "Long Linen";
            longLinenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // customLinenRadioBtn
            // 
            customLinenRadioBtn.AutoSize = true;
            customLinenRadioBtn.Location = new Point(45, 143);
            customLinenRadioBtn.Name = "customLinenRadioBtn";
            customLinenRadioBtn.Size = new Size(111, 23);
            customLinenRadioBtn.TabIndex = 18;
            customLinenRadioBtn.Text = "Custom Linen";
            customLinenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // standardLinenRadioBtn
            // 
            standardLinenRadioBtn.AutoSize = true;
            standardLinenRadioBtn.Checked = true;
            standardLinenRadioBtn.Location = new Point(45, 29);
            standardLinenRadioBtn.Name = "standardLinenRadioBtn";
            standardLinenRadioBtn.Size = new Size(119, 23);
            standardLinenRadioBtn.TabIndex = 16;
            standardLinenRadioBtn.TabStop = true;
            standardLinenRadioBtn.Text = "Standard Linen";
            standardLinenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label3.Location = new Point(597, 296);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 26);
            label3.TabIndex = 21;
            label3.Text = "Select Linens:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 302);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 20;
            label4.Text = "Select Linens:";
            // 
            // tableTopFairCheckBox
            // 
            tableTopFairCheckBox.AutoSize = true;
            tableTopFairCheckBox.Location = new Point(137, 531);
            tableTopFairCheckBox.Name = "tableTopFairCheckBox";
            tableTopFairCheckBox.Size = new Size(117, 23);
            tableTopFairCheckBox.TabIndex = 23;
            tableTopFairCheckBox.Text = "Table Top Fair";
            tableTopFairCheckBox.UseVisualStyleBackColor = true;
            tableTopFairCheckBox.CheckedChanged += tableTopFairCheckBox_CheckedChanged;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 822);
            Controls.Add(tableTopFairCheckBox);
            Controls.Add(linenRadioBtnHolder);
            Controls.Add(label3);
            Controls.Add(infraRadioBtnHolder);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(errorLbl);
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
            Controls.Add(createConfigBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ConfigForm";
            Text = "Form1";
            Load += ConfigForm_Load;
            infraRadioBtnHolder.ResumeLayout(false);
            infraRadioBtnHolder.PerformLayout();
            linenRadioBtnHolder.ResumeLayout(false);
            linenRadioBtnHolder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createConfigBtn;
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
        private Label errorLbl;
        private Label label1;
        private Label label2;
        private RadioButton smallInfraRadioBtn;
        private RadioButton largeInfraRadioBtn;
        private RadioButton customRadioBtn;
        private GroupBox infraRadioBtnHolder;
        private GroupBox linenRadioBtnHolder;
        private RadioButton longLinenRadioBtn;
        private RadioButton customLinenRadioBtn;
        private RadioButton standardLinenRadioBtn;
        private Label label3;
        private Label label4;
        private ComboBox numLinenComboBox;
        private Label numberLinensLbl;
        private CheckBox tableTopFairCheckBox;
    }
}
