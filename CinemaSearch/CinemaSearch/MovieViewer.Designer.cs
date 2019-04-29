namespace CinemaSearch
{
    partial class MovieViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieViewer));
            this.uxMovieListBox = new System.Windows.Forms.ListBox();
            this.uxMovieSearchbox = new System.Windows.Forms.TextBox();
            this.uxSearchTextLabel = new System.Windows.Forms.Label();
            this.uxSearchButtonGo = new System.Windows.Forms.Button();
            this.uxDataName = new System.Windows.Forms.Label();
            this.uxDatalistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxData1 = new System.Windows.Forms.Label();
            this.uxData2 = new System.Windows.Forms.Label();
            this.uxData3 = new System.Windows.Forms.Label();
            this.uxData4 = new System.Windows.Forms.Label();
            this.uxSearchForComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxData5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxData6 = new System.Windows.Forms.Label();
            this.uxEditButton = new System.Windows.Forms.Button();
            this.uxGenreTextBox = new System.Windows.Forms.TextBox();
            this.uxDataListLabel = new System.Windows.Forms.Label();
            this.uxData7 = new System.Windows.Forms.Label();
            this.populateDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxBrowseForDataDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMovieListBox
            // 
            this.uxMovieListBox.FormattingEnabled = true;
            this.uxMovieListBox.ItemHeight = 16;
            this.uxMovieListBox.Location = new System.Drawing.Point(24, 137);
            this.uxMovieListBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxMovieListBox.Name = "uxMovieListBox";
            this.uxMovieListBox.Size = new System.Drawing.Size(309, 388);
            this.uxMovieListBox.TabIndex = 0;
            this.uxMovieListBox.TabStop = false;
            this.uxMovieListBox.SelectedIndexChanged += new System.EventHandler(this.uxDisplayInfo);
            // 
            // uxMovieSearchbox
            // 
            this.uxMovieSearchbox.Location = new System.Drawing.Point(82, 31);
            this.uxMovieSearchbox.Margin = new System.Windows.Forms.Padding(4);
            this.uxMovieSearchbox.Name = "uxMovieSearchbox";
            this.uxMovieSearchbox.Size = new System.Drawing.Size(249, 22);
            this.uxMovieSearchbox.TabIndex = 0;
            // 
            // uxSearchTextLabel
            // 
            this.uxSearchTextLabel.AutoSize = true;
            this.uxSearchTextLabel.Location = new System.Drawing.Point(21, 34);
            this.uxSearchTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxSearchTextLabel.Name = "uxSearchTextLabel";
            this.uxSearchTextLabel.Size = new System.Drawing.Size(49, 17);
            this.uxSearchTextLabel.TabIndex = 2;
            this.uxSearchTextLabel.Text = "Name:";
            // 
            // uxSearchButtonGo
            // 
            this.uxSearchButtonGo.Location = new System.Drawing.Point(262, 91);
            this.uxSearchButtonGo.Margin = new System.Windows.Forms.Padding(4);
            this.uxSearchButtonGo.Name = "uxSearchButtonGo";
            this.uxSearchButtonGo.Size = new System.Drawing.Size(69, 28);
            this.uxSearchButtonGo.TabIndex = 3;
            this.uxSearchButtonGo.Text = "Go";
            this.uxSearchButtonGo.UseVisualStyleBackColor = true;
            this.uxSearchButtonGo.Click += new System.EventHandler(this.uxSearchEvent);
            // 
            // uxDataName
            // 
            this.uxDataName.AutoSize = true;
            this.uxDataName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDataName.Location = new System.Drawing.Point(348, 25);
            this.uxDataName.Name = "uxDataName";
            this.uxDataName.Size = new System.Drawing.Size(151, 29);
            this.uxDataName.TabIndex = 6;
            this.uxDataName.Text = "uxDataName";
            // 
            // uxDatalistBox
            // 
            this.uxDatalistBox.FormattingEnabled = true;
            this.uxDatalistBox.ItemHeight = 16;
            this.uxDatalistBox.Location = new System.Drawing.Point(353, 185);
            this.uxDatalistBox.Name = "uxDatalistBox";
            this.uxDatalistBox.Size = new System.Drawing.Size(493, 340);
            this.uxDatalistBox.TabIndex = 8;
            this.uxDatalistBox.TabStop = false;
            this.uxDatalistBox.Click += new System.EventHandler(this.uxDisplayInfo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Genre:";
            // 
            // uxData1
            // 
            this.uxData1.AutoSize = true;
            this.uxData1.Location = new System.Drawing.Point(350, 64);
            this.uxData1.Name = "uxData1";
            this.uxData1.Size = new System.Drawing.Size(60, 17);
            this.uxData1.TabIndex = 13;
            this.uxData1.Text = "uxData1";
            // 
            // uxData2
            // 
            this.uxData2.AutoSize = true;
            this.uxData2.Location = new System.Drawing.Point(350, 94);
            this.uxData2.Name = "uxData2";
            this.uxData2.Size = new System.Drawing.Size(60, 17);
            this.uxData2.TabIndex = 14;
            this.uxData2.Text = "uxData2";
            // 
            // uxData3
            // 
            this.uxData3.AutoSize = true;
            this.uxData3.Location = new System.Drawing.Point(560, 64);
            this.uxData3.Name = "uxData3";
            this.uxData3.Size = new System.Drawing.Size(60, 17);
            this.uxData3.TabIndex = 15;
            this.uxData3.Text = "uxData3";
            // 
            // uxData4
            // 
            this.uxData4.AutoSize = true;
            this.uxData4.Location = new System.Drawing.Point(560, 94);
            this.uxData4.Name = "uxData4";
            this.uxData4.Size = new System.Drawing.Size(60, 17);
            this.uxData4.TabIndex = 16;
            this.uxData4.Text = "uxData4";
            // 
            // uxSearchForComboBox
            // 
            this.uxSearchForComboBox.FormattingEnabled = true;
            this.uxSearchForComboBox.Items.AddRange(new object[] {
            "Movie",
            "Person"});
            this.uxSearchForComboBox.Location = new System.Drawing.Point(115, 94);
            this.uxSearchForComboBox.Name = "uxSearchForComboBox";
            this.uxSearchForComboBox.Size = new System.Drawing.Size(140, 24);
            this.uxSearchForComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search for...";
            // 
            // uxData5
            // 
            this.uxData5.AutoSize = true;
            this.uxData5.Location = new System.Drawing.Point(350, 123);
            this.uxData5.Name = "uxData5";
            this.uxData5.Size = new System.Drawing.Size(60, 17);
            this.uxData5.TabIndex = 20;
            this.uxData5.Text = "uxData5";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(939, 27);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.populateDatabaseToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem,
            this.movieToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(51, 24);
            this.toolStripDropDownButton2.Text = "Add";
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.personToolStripMenuItem.Text = "Movie";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.uxAddMovie);
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.movieToolStripMenuItem.Text = "Person";
            this.movieToolStripMenuItem.Click += new System.EventHandler(this.uxAddPerson);
            // 
            // uxData6
            // 
            this.uxData6.AutoSize = true;
            this.uxData6.Location = new System.Drawing.Point(560, 123);
            this.uxData6.Name = "uxData6";
            this.uxData6.Size = new System.Drawing.Size(60, 17);
            this.uxData6.TabIndex = 22;
            this.uxData6.Text = "uxData6";
            // 
            // uxEditButton
            // 
            this.uxEditButton.Enabled = false;
            this.uxEditButton.Location = new System.Drawing.Point(852, 502);
            this.uxEditButton.Name = "uxEditButton";
            this.uxEditButton.Size = new System.Drawing.Size(75, 23);
            this.uxEditButton.TabIndex = 23;
            this.uxEditButton.TabStop = false;
            this.uxEditButton.Text = "Edit";
            this.uxEditButton.UseVisualStyleBackColor = true;
            this.uxEditButton.Click += new System.EventHandler(this.uxEditButton_Click);
            // 
            // uxGenreTextBox
            // 
            this.uxGenreTextBox.Location = new System.Drawing.Point(82, 62);
            this.uxGenreTextBox.Name = "uxGenreTextBox";
            this.uxGenreTextBox.Size = new System.Drawing.Size(249, 22);
            this.uxGenreTextBox.TabIndex = 1;
            // 
            // uxDataListLabel
            // 
            this.uxDataListLabel.AutoSize = true;
            this.uxDataListLabel.Location = new System.Drawing.Point(350, 165);
            this.uxDataListLabel.Name = "uxDataListLabel";
            this.uxDataListLabel.Size = new System.Drawing.Size(0, 17);
            this.uxDataListLabel.TabIndex = 24;
            // 
            // uxData7
            // 
            this.uxData7.AutoSize = true;
            this.uxData7.Location = new System.Drawing.Point(782, 64);
            this.uxData7.Name = "uxData7";
            this.uxData7.Size = new System.Drawing.Size(60, 17);
            this.uxData7.TabIndex = 25;
            this.uxData7.Text = "uxData7";
            // 
            // populateDatabaseToolStripMenuItem
            // 
            this.populateDatabaseToolStripMenuItem.Name = "populateDatabaseToolStripMenuItem";
            this.populateDatabaseToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.populateDatabaseToolStripMenuItem.Text = "Populate Database...";
            this.populateDatabaseToolStripMenuItem.Click += new System.EventHandler(this.populateDatabaseToolStripMenuItem_Click);
            // 
            // MovieViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 554);
            this.Controls.Add(this.uxData7);
            this.Controls.Add(this.uxDataListLabel);
            this.Controls.Add(this.uxGenreTextBox);
            this.Controls.Add(this.uxEditButton);
            this.Controls.Add(this.uxData6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uxData5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxSearchForComboBox);
            this.Controls.Add(this.uxData4);
            this.Controls.Add(this.uxData3);
            this.Controls.Add(this.uxData2);
            this.Controls.Add(this.uxData1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDatalistBox);
            this.Controls.Add(this.uxDataName);
            this.Controls.Add(this.uxSearchButtonGo);
            this.Controls.Add(this.uxSearchTextLabel);
            this.Controls.Add(this.uxMovieSearchbox);
            this.Controls.Add(this.uxMovieListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieViewer";
            this.Text = "Cinema Search";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxMovieListBox;
        private System.Windows.Forms.TextBox uxMovieSearchbox;
        private System.Windows.Forms.Label uxSearchTextLabel;
        private System.Windows.Forms.Button uxSearchButtonGo;
        private System.Windows.Forms.Label uxDataName;
        private System.Windows.Forms.ListBox uxDatalistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxData1;
        private System.Windows.Forms.Label uxData2;
        private System.Windows.Forms.Label uxData3;
        private System.Windows.Forms.Label uxData4;
        private System.Windows.Forms.ComboBox uxSearchForComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uxData5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.Label uxData6;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.Button uxEditButton;
        private System.Windows.Forms.TextBox uxGenreTextBox;
        private System.Windows.Forms.Label uxDataListLabel;
        private System.Windows.Forms.Label uxData7;
        private System.Windows.Forms.ToolStripMenuItem populateDatabaseToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog uxBrowseForDataDialog;
    }
}