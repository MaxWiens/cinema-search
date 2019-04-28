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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieListView));
            this.uxMovieListBox = new System.Windows.Forms.ListBox();
            this.uxMovieSearchbox = new System.Windows.Forms.TextBox();
            this.uxSearchTextLabel = new System.Windows.Forms.Label();
            this.uxSearchButtonGo = new System.Windows.Forms.Button();
            this.uxDataName = new System.Windows.Forms.Label();
            this.uxDatalistBox = new System.Windows.Forms.ListBox();
            this.uxPersonTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.uxGenreTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMovieListBox
            // 
            this.uxMovieListBox.FormattingEnabled = true;
            this.uxMovieListBox.ItemHeight = 16;
            this.uxMovieListBox.Location = new System.Drawing.Point(24, 153);
            this.uxMovieListBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxMovieListBox.Name = "uxMovieListBox";
            this.uxMovieListBox.Size = new System.Drawing.Size(309, 372);
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
            this.uxSearchTextLabel.Size = new System.Drawing.Size(39, 17);
            this.uxSearchTextLabel.TabIndex = 2;
            this.uxSearchTextLabel.Text = "Title:";
            // 
            // uxSearchButtonGo
            // 
            this.uxSearchButtonGo.Location = new System.Drawing.Point(262, 117);
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
            // 
            // uxPersonTextBox
            // 
            this.uxPersonTextBox.Location = new System.Drawing.Point(82, 91);
            this.uxPersonTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxPersonTextBox.Name = "uxPersonTextBox";
            this.uxPersonTextBox.Size = new System.Drawing.Size(249, 22);
            this.uxPersonTextBox.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Person:";
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
            this.uxSearchForComboBox.Location = new System.Drawing.Point(115, 120);
            this.uxSearchForComboBox.Name = "uxSearchForComboBox";
            this.uxSearchForComboBox.Size = new System.Drawing.Size(140, 24);
            this.uxSearchForComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
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
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(49, 24);
            this.toolStripDropDownButton2.Text = "Edit";
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
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(852, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uxGenreTextBox
            // 
            this.uxGenreTextBox.Location = new System.Drawing.Point(82, 62);
            this.uxGenreTextBox.Name = "uxGenreTextBox";
            this.uxGenreTextBox.Size = new System.Drawing.Size(249, 22);
            this.uxGenreTextBox.TabIndex = 1;
            // 
            // MovieListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 554);
            this.Controls.Add(this.uxGenreTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxData6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uxData5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxSearchForComboBox);
            this.Controls.Add(this.uxData4);
            this.Controls.Add(this.uxData3);
            this.Controls.Add(this.uxData2);
            this.Controls.Add(this.uxData1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPersonTextBox);
            this.Controls.Add(this.uxDatalistBox);
            this.Controls.Add(this.uxDataName);
            this.Controls.Add(this.uxSearchButtonGo);
            this.Controls.Add(this.uxSearchTextLabel);
            this.Controls.Add(this.uxMovieSearchbox);
            this.Controls.Add(this.uxMovieListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieListView";
            this.Text = "MovieListView";
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
        private System.Windows.Forms.TextBox uxPersonTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox uxGenreTextBox;
    }
}