namespace CinemaSearch
{
    partial class TextDialog
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
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(12, 12);
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(216, 22);
            this.uxTextBox.TabIndex = 0;
            // 
            // uxOkButton
            // 
            this.uxOkButton.Location = new System.Drawing.Point(234, 11);
            this.uxOkButton.Name = "uxOkButton";
            this.uxOkButton.Size = new System.Drawing.Size(75, 23);
            this.uxOkButton.TabIndex = 1;
            this.uxOkButton.Text = "OK";
            this.uxOkButton.UseVisualStyleBackColor = true;
            this.uxOkButton.Click += new System.EventHandler(this.uxOkButton_Click);
            // 
            // TextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 44);
            this.Controls.Add(this.uxOkButton);
            this.Controls.Add(this.uxTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TextDialog";
            this.Text = "TextDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.Button uxOkButton;
    }
}