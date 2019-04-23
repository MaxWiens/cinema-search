namespace CinemaSearch
{
    partial class MovieListView
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
            this.uxMovieListBox = new System.Windows.Forms.ListBox();
            this.uxMovieSearchbox = new System.Windows.Forms.TextBox();
            this.uxSearchTextLabel = new System.Windows.Forms.Label();
            this.uxSearchButtonGo = new System.Windows.Forms.Button();
            this.uxMovieButtonMoreInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxMovieListBox
            // 
            this.uxMovieListBox.FormattingEnabled = true;
            this.uxMovieListBox.Location = new System.Drawing.Point(81, 66);
            this.uxMovieListBox.Name = "uxMovieListBox";
            this.uxMovieListBox.Size = new System.Drawing.Size(204, 225);
            this.uxMovieListBox.TabIndex = 0;
            // 
            // uxMovieSearchbox
            // 
            this.uxMovieSearchbox.Location = new System.Drawing.Point(83, 27);
            this.uxMovieSearchbox.Name = "uxMovieSearchbox";
            this.uxMovieSearchbox.Size = new System.Drawing.Size(100, 20);
            this.uxMovieSearchbox.TabIndex = 1;
            // 
            // uxSearchTextLabel
            // 
            this.uxSearchTextLabel.AutoSize = true;
            this.uxSearchTextLabel.Location = new System.Drawing.Point(36, 27);
            this.uxSearchTextLabel.Name = "uxSearchTextLabel";
            this.uxSearchTextLabel.Size = new System.Drawing.Size(41, 13);
            this.uxSearchTextLabel.TabIndex = 2;
            this.uxSearchTextLabel.Text = "Search";
            // 
            // uxSearchButtonGo
            // 
            this.uxSearchButtonGo.Location = new System.Drawing.Point(210, 27);
            this.uxSearchButtonGo.Name = "uxSearchButtonGo";
            this.uxSearchButtonGo.Size = new System.Drawing.Size(75, 23);
            this.uxSearchButtonGo.TabIndex = 3;
            this.uxSearchButtonGo.Text = "Go";
            this.uxSearchButtonGo.UseVisualStyleBackColor = true;
            this.uxSearchButtonGo.Click += new System.EventHandler(this.uxSearchButtonGo_Click);
            // 
            // uxMovieButtonMoreInfo
            // 
            this.uxMovieButtonMoreInfo.Location = new System.Drawing.Point(142, 308);
            this.uxMovieButtonMoreInfo.Name = "uxMovieButtonMoreInfo";
            this.uxMovieButtonMoreInfo.Size = new System.Drawing.Size(75, 23);
            this.uxMovieButtonMoreInfo.TabIndex = 4;
            this.uxMovieButtonMoreInfo.Text = "More Info";
            this.uxMovieButtonMoreInfo.UseVisualStyleBackColor = true;
            this.uxMovieButtonMoreInfo.Click += new System.EventHandler(this.uxMovieButtonMoreInfo_Click);
            // 
            // MovieListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxMovieButtonMoreInfo);
            this.Controls.Add(this.uxSearchButtonGo);
            this.Controls.Add(this.uxSearchTextLabel);
            this.Controls.Add(this.uxMovieSearchbox);
            this.Controls.Add(this.uxMovieListBox);
            this.Name = "MovieListView";
            this.Text = "MovieListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxMovieListBox;
        private System.Windows.Forms.TextBox uxMovieSearchbox;
        private System.Windows.Forms.Label uxSearchTextLabel;
        private System.Windows.Forms.Button uxSearchButtonGo;
        private System.Windows.Forms.Button uxMovieButtonMoreInfo;
    }
}
