namespace TelephoneNumberConverter
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.alphaNumTextBox = new System.Windows.Forms.TextBox();
            this.convertionLabel = new System.Windows.Forms.Label();
            this.convNumLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(31, 22);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(331, 32);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter a telephone number containing letters in the \r\nfollowing format: XXX-XXXXXX" +
    "XX (e.g. 800-FLOWERS). \r\n";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaNumTextBox
            // 
            this.alphaNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaNumTextBox.Location = new System.Drawing.Point(123, 77);
            this.alphaNumTextBox.Name = "alphaNumTextBox";
            this.alphaNumTextBox.Size = new System.Drawing.Size(142, 22);
            this.alphaNumTextBox.TabIndex = 1;
            this.alphaNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convertionLabel
            // 
            this.convertionLabel.AutoSize = true;
            this.convertionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertionLabel.Location = new System.Drawing.Point(70, 125);
            this.convertionLabel.Name = "convertionLabel";
            this.convertionLabel.Size = new System.Drawing.Size(249, 16);
            this.convertionLabel.TabIndex = 2;
            this.convertionLabel.Text = "This is your number\'s numeric equvalent.";
            // 
            // convNumLabel
            // 
            this.convNumLabel.BackColor = System.Drawing.SystemColors.Window;
            this.convNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convNumLabel.Location = new System.Drawing.Point(123, 171);
            this.convNumLabel.Name = "convNumLabel";
            this.convNumLabel.Size = new System.Drawing.Size(142, 23);
            this.convNumLabel.TabIndex = 3;
            this.convNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(61, 228);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(115, 33);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert Number";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(204, 228);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 33);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 301);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convNumLabel);
            this.Controls.Add(this.convertionLabel);
            this.Controls.Add(this.alphaNumTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Telephone Number Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox alphaNumTextBox;
        private System.Windows.Forms.Label convertionLabel;
        private System.Windows.Forms.Label convNumLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

