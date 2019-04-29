using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSearch
{
    public partial class TextDialog : Form
    {
        public string Result { get; private set; }
        public TextDialog(string title)
        {
            InitializeComponent();
            Text = title;
        }

        private void uxOkButton_Click(object sender, EventArgs e)
        {
            Result = uxTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
