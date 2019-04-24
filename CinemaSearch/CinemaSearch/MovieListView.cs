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

            string userSearchText = uxSearchTextLabel.Text;
            // run query looking for something with
            Dictionary<string, string> queryDict = new Dictionary<string, string>();
            queryDict.Add("title", userSearchText);
            SqlQueryExecutor s = new SqlQueryExecutor("Data Source=mssql.cs.ksu.edu;Integrated Security=True");
            s.SearchByTitle(title:"bee movie");
        }

        private void uxMovieButtonMoreInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
