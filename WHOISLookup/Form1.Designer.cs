namespace WHOISLookup
{
    partial class Form1
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.domainLabel = new System.Windows.Forms.Label();
            this.domainText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(13, 397);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(127, 41);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainLabel
            // 
            this.domainLabel.Location = new System.Drawing.Point(14, 0);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(126, 22);
            this.domainLabel.TabIndex = 6;
            this.domainLabel.Text = "Domain:";
            this.domainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // domainText
            // 
            this.domainText.Location = new System.Drawing.Point(13, 25);
            this.domainText.Name = "domainText";
            this.domainText.Size = new System.Drawing.Size(126, 20);
            this.domainText.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(146, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(641, 433);
            this.listBox1.TabIndex = 10;
            this.listBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.domainLabel);
            this.Controls.Add(this.domainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.TextBox domainText;
        private System.Windows.Forms.ListBox listBox1;
    }
}

