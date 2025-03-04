﻿namespace JFtextCs
{
    partial class AboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            tableLayoutPanel = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            labelProductName = new Label();
            labelVersion = new Label();
            labelCompanyName = new Label();
            textBoxDescription = new TextBox();
            okButton = new Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
            tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
            tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
            tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
            tableLayoutPanel.Controls.Add(okButton, 1, 5);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(20, 22);
            tableLayoutPanel.Margin = new Padding(6, 7, 6, 7);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.647779F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 1.37825418F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.575804F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60.1837654F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.Size = new Size(903, 653);
            tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(6, 7);
            logoPictureBox.Margin = new Padding(6, 7, 6, 7);
            logoPictureBox.Name = "logoPictureBox";
            tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
            logoPictureBox.Size = new Size(285, 639);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 12;
            logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            labelProductName.Dock = DockStyle.Fill;
            labelProductName.Font = new Font("JetBrains Mono ExtraBold", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProductName.Location = new Point(310, 0);
            labelProductName.Margin = new Padding(13, 0, 6, 0);
            labelProductName.MaximumSize = new Size(0, 42);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(587, 42);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "JFtext";
            labelProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            labelVersion.Dock = DockStyle.Fill;
            labelVersion.Font = new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVersion.Location = new Point(310, 65);
            labelVersion.Margin = new Padding(13, 0, 6, 0);
            labelVersion.MaximumSize = new Size(0, 42);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(587, 42);
            labelVersion.TabIndex = 0;
            labelVersion.TextAlign = ContentAlignment.MiddleLeft;
            labelVersion.Click += labelVersion_Click;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Dock = DockStyle.Fill;
            labelCompanyName.Font = new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCompanyName.Location = new Point(310, 137);
            labelCompanyName.Margin = new Padding(13, 0, 6, 0);
            labelCompanyName.MaximumSize = new Size(0, 42);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(587, 42);
            labelCompanyName.TabIndex = 22;
            labelCompanyName.Text = "Jface_programming";
            labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Font = new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxDescription.Location = new Point(310, 200);
            textBoxDescription.Margin = new Padding(13, 7, 6, 7);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = ScrollBars.Both;
            textBoxDescription.Size = new Size(587, 379);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TabStop = false;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(735, 593);
            okButton.Margin = new Padding(6, 7, 6, 7);
            okButton.Name = "okButton";
            okButton.Size = new Size(162, 53);
            okButton.TabIndex = 24;
            okButton.Text = "&OK";
            // 
            // AboutBox1
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 697);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox1";
            Padding = new Padding(20, 22, 20, 22);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button okButton;
        private TextBox textBoxDescription;
        private Label labelVersion;
    }
}
