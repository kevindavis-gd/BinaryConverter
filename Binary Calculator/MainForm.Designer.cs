namespace Binary_Calculator
{
    partial class mainForm
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
            this.binaryInput = new System.Windows.Forms.TextBox();
            this.binaryInputLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // binaryInput
            // 
            this.binaryInput.Location = new System.Drawing.Point(48, 56);
            this.binaryInput.Name = "binaryInput";
            this.binaryInput.Size = new System.Drawing.Size(220, 22);
            this.binaryInput.TabIndex = 0;
            // 
            // binaryInputLabel
            // 
            this.binaryInputLabel.AutoSize = true;
            this.binaryInputLabel.Location = new System.Drawing.Point(48, 33);
            this.binaryInputLabel.Name = "binaryInputLabel";
            this.binaryInputLabel.Size = new System.Drawing.Size(141, 17);
            this.binaryInputLabel.TabIndex = 1;
            this.binaryInputLabel.Text = "Insert Binary Number";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(86, 109);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(126, 48);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(45, 160);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 17);
            this.Output.TabIndex = 3;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(219, 109);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 48);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear Screen";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 399);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.binaryInputLabel);
            this.Controls.Add(this.binaryInput);
            this.Name = "mainForm";
            this.Text = "Binary Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox binaryInput;
        private System.Windows.Forms.Label binaryInputLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button ClearButton;
    }
}

