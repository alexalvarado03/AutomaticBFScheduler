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
            SuspendLayout();
            // 
            // createConfigBtn
            // 
            createConfigBtn.Location = new Point(100, 72);
            createConfigBtn.Margin = new Padding(4);
            createConfigBtn.Name = "createConfigBtn";
            createConfigBtn.Size = new Size(275, 29);
            createConfigBtn.TabIndex = 0;
            createConfigBtn.Text = "Create Config";
            createConfigBtn.UseVisualStyleBackColor = true;
            // 
            // smallSilverTB
            // 
            smallSilverTB.Location = new Point(289, 166);
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
            caseSizeLbl.Location = new Point(60, 117);
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
            smallSilverLbl.Location = new Point(59, 171);
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
            smallRainbowLbl.Location = new Point(59, 227);
            smallRainbowLbl.Margin = new Padding(4, 0, 4, 0);
            smallRainbowLbl.Name = "smallRainbowLbl";
            smallRainbowLbl.Size = new Size(103, 19);
            smallRainbowLbl.TabIndex = 5;
            smallRainbowLbl.Text = "Small Rainbow:";
            // 
            // smallRainbowTB
            // 
            smallRainbowTB.Location = new Point(289, 222);
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
            mediumLbl.Location = new Point(59, 285);
            mediumLbl.Margin = new Padding(4, 0, 4, 0);
            mediumLbl.Name = "mediumLbl";
            mediumLbl.Size = new Size(62, 19);
            mediumLbl.TabIndex = 7;
            mediumLbl.Text = "Medium:";
            // 
            // mediumTB
            // 
            mediumTB.Location = new Point(289, 280);
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
            mediumPebbleLbl.Location = new Point(59, 341);
            mediumPebbleLbl.Margin = new Padding(4, 0, 4, 0);
            mediumPebbleLbl.Name = "mediumPebbleLbl";
            mediumPebbleLbl.Size = new Size(136, 19);
            mediumPebbleLbl.TabIndex = 9;
            mediumPebbleLbl.Text = "Medium Pebble Top:";
            // 
            // mediumPebbleTB
            // 
            mediumPebbleTB.Location = new Point(289, 341);
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
            amountLbl.Location = new Point(284, 117);
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
            largeLbl.Location = new Point(59, 408);
            largeLbl.Margin = new Padding(4, 0, 4, 0);
            largeLbl.Name = "largeLbl";
            largeLbl.Size = new Size(47, 19);
            largeLbl.TabIndex = 12;
            largeLbl.Text = "Large:";
            // 
            // largeTB
            // 
            largeTB.Location = new Point(289, 408);
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
            errorLbl.Location = new Point(197, 495);
            errorLbl.Margin = new Padding(4, 0, 4, 0);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(0, 19);
            errorLbl.TabIndex = 13;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 822);
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
    }
}
