namespace JFtextCs
{
    partial class Form1
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
            textArea = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textArea
            // 
            textArea.Location = new Point(11, 64);
            textArea.Name = "textArea";
            textArea.Size = new Size(1544, 827);
            textArea.TabIndex = 0;
            textArea.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 1;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1568, 903);
            Controls.Add(button1);
            Controls.Add(textArea);
            Name = "Form1";
            Text = "JFtext";
            ResumeLayout(false);
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        #endregion

        private RichTextBox textArea;
        private Button button1;
    }
}
