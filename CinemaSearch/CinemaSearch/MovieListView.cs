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
    public partial class MovieListView : Form
    {
        public MovieListView()
        {
            InitializeComponent();
        }

        private void uxSearchButtonGo_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null) throw new Exception("Object was not of type button");
            string userSearchText = b.Text;
            // run query looking for something with
            var queryArgs = (title: userSearchText,);
        }

        private void uxMovieButtonMoreInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
