namespace string2md5g
{
    partial class MD5Form
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
            this.labelInput = new System.Windows.Forms.Label();
            this.labelMD5 = new System.Windows.Forms.Label();
            this.inputControl = new System.Windows.Forms.TextBox();
            this.md5OutputControl = new System.Windows.Forms.TextBox();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 12);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // labelMD5
            // 
            this.labelMD5.AutoSize = true;
            this.labelMD5.Location = new System.Drawing.Point(12, 39);
            this.labelMD5.Name = "labelMD5";
            this.labelMD5.Size = new System.Drawing.Size(30, 13);
            this.labelMD5.TabIndex = 1;
            this.labelMD5.Text = "MD5";
            // 
            // inputControl
            // 
            this.inputControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControl.Location = new System.Drawing.Point(53, 9);
            this.inputControl.Name = "inputControl";
            this.inputControl.Size = new System.Drawing.Size(445, 20);
            this.inputControl.TabIndex = 2;
            this.inputControl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // md5OutputControl
            // 
            this.md5OutputControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.md5OutputControl.Location = new System.Drawing.Point(53, 32);
            this.md5OutputControl.Name = "md5OutputControl";
            this.md5OutputControl.ReadOnly = true;
            this.md5OutputControl.Size = new System.Drawing.Size(445, 20);
            this.md5OutputControl.TabIndex = 3;
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(390, 58);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(108, 23);
            this.buttonCopyToClipboard.TabIndex = 4;
            this.buttonCopyToClipboard.Text = "Copy To Clipboard";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // MD5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 92);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.md5OutputControl);
            this.Controls.Add(this.inputControl);
            this.Controls.Add(this.labelMD5);
            this.Controls.Add(this.labelInput);
            this.Name = "MD5Form";
            this.Text = "String 2 MD5 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelMD5;
        private System.Windows.Forms.TextBox inputControl;
        private System.Windows.Forms.TextBox md5OutputControl;
        private System.Windows.Forms.Button buttonCopyToClipboard;
    }
}

