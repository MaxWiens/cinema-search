using System;
using System.Collections;
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

        private SqlInterface _sqlinterface;

        public MovieListView()
        {
            InitializeComponent();

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";

            _sqlinterface = new SqlInterface(connectionString);
            _sqlinterface.InitalizeDatabase();
        }

        private void uxSearchButtonGo_Click(object sender, EventArgs e)
        {

            string searchText = uxMovieSearchbox.Text;

            if (searchText != "")
            {
                Dictionary<string, string> queryDict = new Dictionary<string, string>();
                queryDict.Add("title", searchText);

                ArrayList results = _sqlinterface.SearchByTitle(searchText);
                uxMovieListBox.DataSource = results;
            }
        }

        private void uxMovieButtonMoreInfo_Click(object sender, EventArgs e)
        {
            _sqlinterface.SearchByTitle("Bee");
        }
    }
}
