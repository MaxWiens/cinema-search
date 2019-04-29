namespace CinemaSearch
{
    partial class MovieEditor
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
            this.uxTitleTextBox = new System.Windows.Forms.TextBox();
            this.uxSubmitButton = new System.Windows.Forms.Button();
            this.uxGenresTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxRuntimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxRatingTextBox = new System.Windows.Forms.TextBox();
            this.uxSearchTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uxSearchListBox = new System.Windows.Forms.ListBox();
            this.uxAddActorButton = new System.Windows.Forms.Button();
            this.uxAddDirectorButton = new System.Windows.Forms.Button();
            this.uxActorsListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxRemoveActorButton = new System.Windows.Forms.Button();
            this.uxAdultCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uxDirectorTextBox = new System.Windows.Forms.TextBox();
            this.uxRemoveDirectorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTitleTextBox
            // 
            this.uxTitleTextBox.Location = new System.Drawing.Point(57, 12);
            this.uxTitleTextBox.Name = "uxTitleTextBox";
            this.uxTitleTextBox.Size = new System.Drawing.Size(164, 22);
            this.uxTitleTextBox.TabIndex = 0;
            this.uxTitleTextBox.TextChanged += new System.EventHandler(this.EnsureNotEmpty);
            // 
            // uxSubmitButton
            // 
            this.uxSubmitButton.Enabled = false;
            this.uxSubmitButton.Location = new System.Drawing.Point(478, 415);
            this.uxSubmitButton.Name = "uxSubmitButton";
            this.uxSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.uxSubmitButton.TabIndex = 1;
            this.uxSubmitButton.Text = "Submit";
            this.uxSubmitButton.UseVisualStyleBackColor = true;
            this.uxSubmitButton.Click += new System.EventHandler(this.uxSubmitButton_Click);
            // 
            // uxGenresTextBox
            // 
            this.uxGenresTextBox.Location = new System.Drawing.Point(77, 68);
            this.uxGenresTextBox.Name = "uxGenresTextBox";
            this.uxGenresTextBox.Size = new System.Drawing.Size(144, 22);
            this.uxGenresTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Runtime:";
            // 
            // uxRuntimeTextBox
            // 
            this.uxRuntimeTextBox.Location = new System.Drawing.Point(82, 40);
            this.uxRuntimeTextBox.Name = "uxRuntimeTextBox";
            this.uxRuntimeTextBox.Size = new System.Drawing.Size(58, 22);
            this.uxRuntimeTextBox.TabIndex = 1;
            this.uxRuntimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnsureOnlyNumbers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Release Year:";
            // 
            // uxReleaseYearTextBox
            // 
            this.uxReleaseYearTextBox.Location = new System.Drawing.Point(113, 96);
            this.uxReleaseYearTextBox.Name = "uxReleaseYearTextBox";
            this.uxReleaseYearTextBox.Size = new System.Drawing.Size(69, 22);
            this.uxReleaseYearTextBox.TabIndex = 3;
            this.uxReleaseYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnsureOnlyNumbers);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rating: ";
            // 
            // uxRatingTextBox
            // 
            this.uxRatingTextBox.Location = new System.Drawing.Point(113, 124);
            this.uxRatingTextBox.Name = "uxRatingTextBox";
            this.uxRatingTextBox.Size = new System.Drawing.Size(44, 22);
            this.uxRatingTextBox.TabIndex = 4;
            this.uxRatingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnsureOnlyDecimal);
            // 
            // uxSearchTextBox
            // 
            this.uxSearchTextBox.Location = new System.Drawing.Point(450, 12);
            this.uxSearchTextBox.Name = "uxSearchTextBox";
            this.uxSearchTextBox.Size = new System.Drawing.Size(100, 22);
            this.uxSearchTextBox.TabIndex = 6;
            this.uxSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxSearchTextBox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search For Person:";
            // 
            // uxSearchListBox
            // 
            this.uxSearchListBox.FormattingEnabled = true;
            this.uxSearchListBox.ItemHeight = 16;
            this.uxSearchListBox.Location = new System.Drawing.Point(311, 40);
            this.uxSearchListBox.Name = "uxSearchListBox";
            this.uxSearchListBox.Size = new System.Drawing.Size(242, 324);
            this.uxSearchListBox.TabIndex = 15;
            // 
            // uxAddActorButton
            // 
            this.uxAddActorButton.Enabled = false;
            this.uxAddActorButton.Location = new System.Drawing.Point(435, 370);
            this.uxAddActorButton.Name = "uxAddActorButton";
            this.uxAddActorButton.Size = new System.Drawing.Size(118, 23);
            this.uxAddActorButton.TabIndex = 16;
            this.uxAddActorButton.Text = "Add As Actor";
            this.uxAddActorButton.UseVisualStyleBackColor = true;
            this.uxAddActorButton.Click += new System.EventHandler(this.uxAddActorButton_Click);
            // 
            // uxAddDirectorButton
            // 
            this.uxAddDirectorButton.Enabled = false;
            this.uxAddDirectorButton.Location = new System.Drawing.Point(311, 370);
            this.uxAddDirectorButton.Name = "uxAddDirectorButton";
            this.uxAddDirectorButton.Size = new System.Drawing.Size(118, 23);
            this.uxAddDirectorButton.TabIndex = 17;
            this.uxAddDirectorButton.Text = "Add As Director";
            this.uxAddDirectorButton.UseVisualStyleBackColor = true;
            this.uxAddDirectorButton.Click += new System.EventHandler(this.uxAddDirectorButton_Click);
            // 
            // uxActorsListBox
            // 
            this.uxActorsListBox.FormattingEnabled = true;
            this.uxActorsListBox.ItemHeight = 16;
            this.uxActorsListBox.Location = new System.Drawing.Point(15, 226);
            this.uxActorsListBox.Name = "uxActorsListBox";
            this.uxActorsListBox.Size = new System.Drawing.Size(206, 212);
            this.uxActorsListBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "/ 10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "minutes";
            // 
            // uxRemoveActorButton
            // 
            this.uxRemoveActorButton.Enabled = false;
            this.uxRemoveActorButton.Location = new System.Drawing.Point(227, 415);
            this.uxRemoveActorButton.Name = "uxRemoveActorButton";
            this.uxRemoveActorButton.Size = new System.Drawing.Size(75, 23);
            this.uxRemoveActorButton.TabIndex = 21;
            this.uxRemoveActorButton.Text = "Remove";
            this.uxRemoveActorButton.UseVisualStyleBackColor = true;
            // 
            // uxAdultCheckBox
            // 
            this.uxAdultCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uxAdultCheckBox.Location = new System.Drawing.Point(10, 152);
            this.uxAdultCheckBox.Name = "uxAdultCheckBox";
            this.uxAdultCheckBox.Size = new System.Drawing.Size(108, 21);
            this.uxAdultCheckBox.TabIndex = 5;
            this.uxAdultCheckBox.Text = "Adult Movie";
            this.uxAdultCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Actors:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Director: ";
            // 
            // uxDirectorTextBox
            // 
            this.uxDirectorTextBox.Enabled = false;
            this.uxDirectorTextBox.Location = new System.Drawing.Point(77, 173);
            this.uxDirectorTextBox.Name = "uxDirectorTextBox";
            this.uxDirectorTextBox.Size = new System.Drawing.Size(144, 22);
            this.uxDirectorTextBox.TabIndex = 24;
            // 
            // uxRemoveDirectorButton
            // 
            this.uxRemoveDirectorButton.Enabled = false;
            this.uxRemoveDirectorButton.Location = new System.Drawing.Point(227, 173);
            this.uxRemoveDirectorButton.Name = "uxRemoveDirectorButton";
            this.uxRemoveDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.uxRemoveDirectorButton.TabIndex = 25;
            this.uxRemoveDirectorButton.Text = "Remove";
            this.uxRemoveDirectorButton.UseVisualStyleBackColor = true;
            // 
            // MovieEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.uxRemoveDirectorButton);
            this.Controls.Add(this.uxDirectorTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uxAdultCheckBox);
            this.Controls.Add(this.uxRemoveActorButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uxActorsListBox);
            this.Controls.Add(this.uxAddDirectorButton);
            this.Controls.Add(this.uxAddActorButton);
            this.Controls.Add(this.uxSearchListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxSearchTextBox);
            this.Controls.Add(this.uxRatingTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxReleaseYearTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxRuntimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGenresTextBox);
            this.Controls.Add(this.uxSubmitButton);
            this.Controls.Add(this.uxTitleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MovieEditor";
            this.Text = "Movie Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTitleTextBox;
        private System.Windows.Forms.Button uxSubmitButton;
        private System.Windows.Forms.TextBox uxGenresTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxRuntimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxReleaseYearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxRatingTextBox;
        private System.Windows.Forms.TextBox uxSearchTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox uxSearchListBox;
        private System.Windows.Forms.Button uxAddActorButton;
        private System.Windows.Forms.Button uxAddDirectorButton;
        private System.Windows.Forms.ListBox uxActorsListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button uxRemoveActorButton;
        private System.Windows.Forms.CheckBox uxAdultCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uxDirectorTextBox;
        private System.Windows.Forms.Button uxRemoveDirectorButton;
    }
}