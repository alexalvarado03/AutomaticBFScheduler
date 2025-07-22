namespace BFConfigApp
{
    partial class CaseFairConfig
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
            backBtn = new Button();
            flowLayoutPanelHolder = new FlowLayoutPanel();
            tableLayoutPanel = new TableLayoutPanel();
            ConfigurationNameTB = new TextBox();
            EnterNameLabel = new Label();
            SaveButton = new Button();
            ErrorLabel = new Label();
            flowLayoutPanelHolder.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // flowLayoutPanelHolder
            // 
            flowLayoutPanelHolder.AutoScroll = true;
            flowLayoutPanelHolder.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelHolder.Controls.Add(tableLayoutPanel);
            flowLayoutPanelHolder.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelHolder.Location = new Point(84, 230);
            flowLayoutPanelHolder.Name = "flowLayoutPanelHolder";
            flowLayoutPanelHolder.Size = new Size(1413, 482);
            flowLayoutPanelHolder.TabIndex = 1;
            flowLayoutPanelHolder.WrapContents = false;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Location = new Point(3, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(0, 0);
            tableLayoutPanel.TabIndex = 0;
            // 
            // ConfigurationNameTB
            // 
            ConfigurationNameTB.ForeColor = SystemColors.WindowFrame;
            ConfigurationNameTB.Location = new Point(84, 127);
            ConfigurationNameTB.Name = "ConfigurationNameTB";
            ConfigurationNameTB.Size = new Size(329, 23);
            ConfigurationNameTB.TabIndex = 2;
            ConfigurationNameTB.Text = "Enter name here...";
            ConfigurationNameTB.TextChanged += ConfigurationNameTB_TextChanged;
            // 
            // EnterNameLabel
            // 
            EnterNameLabel.AutoSize = true;
            EnterNameLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            EnterNameLabel.Location = new Point(88, 84);
            EnterNameLabel.Name = "EnterNameLabel";
            EnterNameLabel.Size = new Size(224, 19);
            EnterNameLabel.TabIndex = 3;
            EnterNameLabel.Text = "Enter configuration name below:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(1497, 12);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(86, 183);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 5;
            // 
            // CaseFairConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 811);
            Controls.Add(ErrorLabel);
            Controls.Add(SaveButton);
            Controls.Add(EnterNameLabel);
            Controls.Add(ConfigurationNameTB);
            Controls.Add(flowLayoutPanelHolder);
            Controls.Add(backBtn);
            Name = "CaseFairConfig";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanelHolder.ResumeLayout(false);
            flowLayoutPanelHolder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private FlowLayoutPanel flowLayoutPanelHolder;
        private TableLayoutPanel tableLayoutPanel;
        private TextBox ConfigurationNameTB;
        private Label EnterNameLabel;
        private Button SaveButton;
        private Label ErrorLabel;
    }
}