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

        private void uxSearchEvent(object sender, EventArgs e)
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

        }

        private void DisplayPerson(Person person)
        {
            uxDataName.Text = person.Name;

            if(person.BirthYear.HasValue)
                uxData1.Text = "Born: " + person.BirthYear.Value;

            // associated movies
            uxDatalistBox.DataSource = person.Movies;
        }

        private void DisplayMovie(Movie movie)
        {
            uxDataName.Text = movie.Title;

            // release year
            if (movie.ReleaseYear.HasValue)
                uxData1.Text = $"Release year: " + movie.ReleaseYear.Value;
            else
                uxData1.Text = "Unknown Release Date";

            // runtime
            if (movie.Runtime.HasValue)
            {
                int hours = movie.Runtime.Value / 60;
                int minutes = movie.Runtime.Value % 60;
                if (hours > 0 && minutes > 0)
                    uxData2.Text = $"Runtime: {hours} hours {minutes} minutes";
                else if (hours > 0)
                    uxData2.Text = $"Runtime: {hours} hours";
                else
                    uxData2.Text = $"Runtime: {minutes} minutes";
            }
            else
                uxData2.Text = "No Runtime Data";

            // director
            if (movie.Director != null)
                uxData3.Text = "Directed by: " + movie.Director;
            else
                uxData3.Text = "No Director Data";


            // rating
            if (movie.Rating.HasValue)
                uxData5.Text = $"Rating: {movie.Rating.HasValue}/10";
            else
                uxData5.Text = "No Rating Data";


            // is adult
            if (movie.IsAdult.HasValue && movie.IsAdult.Value)
                uxData5.Text = "Adult Movie";
            else
                uxData5.Text = "";

            // actor list
            uxDatalistBox.DataSource = movie.Actors;
        }
    }
}
