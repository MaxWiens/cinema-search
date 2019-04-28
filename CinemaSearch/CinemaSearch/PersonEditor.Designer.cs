namespace CinemaSearch
{
    partial class PersonEditor
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
            this.uxNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxBirthYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.Location = new System.Drawing.Point(66, 12);
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.Size = new System.Drawing.Size(127, 22);
            this.uxNameTextBox.TabIndex = 0;
            this.uxNameTextBox.TextChanged += new System.EventHandler(this.uxNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // uxSubmitButton
            // 
            this.uxSubmitButton.Enabled = false;
            this.uxSubmitButton.Location = new System.Drawing.Point(199, 40);
            this.uxSubmitButton.Name = "uxSubmitButton";
            this.uxSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.uxSubmitButton.TabIndex = 2;
            this.uxSubmitButton.Text = "Submit";
            this.uxSubmitButton.UseVisualStyleBackColor = true;
            this.uxSubmitButton.Click += new System.EventHandler(this.uxSubmitButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birth Year:";
            // 
            // uxBirthYear
            // 
            this.uxBirthYear.Location = new System.Drawing.Point(93, 40);
            this.uxBirthYear.Name = "uxBirthYear";
            this.uxBirthYear.Size = new System.Drawing.Size(100, 22);
            this.uxBirthYear.TabIndex = 3;
            this.uxBirthYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxBirthYear_KeyPress);
            // 
            // PersonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 74);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxBirthYear);
            this.Controls.Add(this.uxSubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxNameTextBox);
            this.Name = "PersonEditor";
            this.Text = "PersonEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxSubmitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxBirthYear;
    }
}