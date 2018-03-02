namespace begtodiffer
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
            this.inputLeft = new System.Windows.Forms.TextBox();
            this.inputRight = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLeft
            // 
            this.inputLeft.BackColor = System.Drawing.SystemColors.MenuText;
            this.inputLeft.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputLeft.Location = new System.Drawing.Point(1, 1);
            this.inputLeft.Multiline = true;
            this.inputLeft.Name = "inputLeft";
            this.inputLeft.Size = new System.Drawing.Size(432, 272);
            this.inputLeft.TabIndex = 0;
            this.inputLeft.Text = "This is a bunch of text\r\nthat is nearly the same.\r\nBut is differnt in two\r\nplaces" +
    ".\r\n";
            this.inputLeft.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputRight
            // 
            this.inputRight.BackColor = System.Drawing.SystemColors.MenuText;
            this.inputRight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputRight.Location = new System.Drawing.Point(439, 1);
            this.inputRight.Multiline = true;
            this.inputRight.Name = "inputRight";
            this.inputRight.Size = new System.Drawing.Size(423, 272);
            this.inputRight.TabIndex = 1;
            this.inputRight.Text = "This is a bunch of text\r\nthat is almost the same.\r\nBut is differnt in two\r\nplaces" +
    "!\r\n";
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.MenuText;
            this.resultText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.resultText.Location = new System.Drawing.Point(1, 321);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(861, 325);
            this.resultText.TabIndex = 2;
            this.resultText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(861, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Diff!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(863, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.inputRight);
            this.Controls.Add(this.inputLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputLeft;
        private System.Windows.Forms.TextBox inputRight;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button button1;
    }
}

