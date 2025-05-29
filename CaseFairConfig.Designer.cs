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
            flowLayoutPanelHolder.Location = new Point(84, 53);
            flowLayoutPanelHolder.Name = "flowLayoutPanelHolder";
            flowLayoutPanelHolder.Size = new Size(1413, 634);
            flowLayoutPanelHolder.TabIndex = 1;
            flowLayoutPanelHolder.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Location = new Point(3, 3);
            tableLayoutPanel.Name = "tableLayoutPanel1";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(0, 0);
            tableLayoutPanel.TabIndex = 0;
            // 
            // CaseFairConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 811);
            Controls.Add(flowLayoutPanelHolder);
            Controls.Add(backBtn);
            Name = "CaseFairConfig";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanelHolder.ResumeLayout(false);
            flowLayoutPanelHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backBtn;
        private FlowLayoutPanel flowLayoutPanelHolder;
        private TableLayoutPanel tableLayoutPanel;
    }
}