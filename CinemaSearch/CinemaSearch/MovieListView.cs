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
        private object _currentlyDisplayed;

        public MovieListView()
        {
            InitializeComponent();

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";

            _sqlinterface = new SqlInterface(connectionString);
            _sqlinterface.InitalizeDatabase();
            uxResetInfo();
            uxSearchForComboBox.SelectedIndex = 0;
            uxSearchForComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void uxSearchEvent(object sender, EventArgs e)
        {
            string title = uxMovieSearchbox.Text;
            string genre = uxGenreTextBox.Text;
            string person = uxPersonTextBox.Text;
            List<Movie> results = _sqlinterface.MovieSearch(title, genre, person);
            uxMovieListBox.DataSource = results;
        }

        private void DisplayPerson(Person person)
        {
            _currentlyDisplayed = person;
            uxDataName.Text = person.Name;

            if(person.BirthYear.HasValue)
                uxData1.Text = "Born: " + person.BirthYear.Value;

            // associated movies
            uxDatalistBox.DataSource = person.Movies;
        }

        private void DisplayMovie(Movie movie)
        {
            _currentlyDisplayed = movie;
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

                StringBuilder sb = new StringBuilder("Runtime: ");

                if (hours == 1)
                    sb.Append("1 hour ");
                else if (hours > 1)
                {
                    sb.Append(hours);
                    sb.Append(" hours ");
                }

                if (minutes == 1)
                    sb.Append("1 minute");
                else if (minutes > 1)
                {
                    sb.Append(minutes);
                    sb.Append(" minutes");
                }
                uxData2.Text = sb.ToString();
            }
            else
                uxData2.Text = "No Runtime Data";


            // director
            if (movie.Director != null)
            {
                uxData3.Click -= DisplayDirector;
                uxData3.Text = "Directed by: " + movie.Director.Name;
                uxData3.Click += DisplayDirector;
            }
            else
            {
                uxData3.Text = "No Director Data";
                uxData3.Click -= DisplayDirector;
            }


            // rating
            if (movie.Rating.HasValue)
                uxData4.Text = $"Rating: {movie.Rating.Value}/10";
            else
                uxData4.Text = "No Rating Data";

            // genres
            if (movie.Genre != null)
                uxData5.Text = "Genre(s): " + movie.Genre;
            else
                uxData5.Text = "No Genre data";

            // is adult
            if (movie.IsAdult.HasValue && movie.IsAdult.Value)
                uxData6.Text = "Adult Movie";
            else
                uxData6.Text = "";

            // actor list
            uxDatalistBox.DataSource = movie.Actors;
        }

        private void DisplayDirector(object sender, EventArgs e)
        {
            MessageBox.Show("nice");
        }

        private void uxResetInfo()
        {
            uxDataName.Text = String.Empty;
            uxData1.Text = String.Empty;
            uxData2.Text = String.Empty;
            uxData3.Text = String.Empty;
            uxData4.Text = String.Empty;
            uxData5.Text = String.Empty;
            uxData6.Text = String.Empty;
            uxDatalistBox.DataSource = null;
        }

        private void uxDisplayInfo(object sender, EventArgs e)
        {
            
            if(sender.GetType() == typeof(ListBox))
            {
                object datasource = ((ListBox)sender).DataSource;
                if (datasource.GetType() == typeof(List<Movie>))
                {
                    Movie selectedMovie = ((List<Movie>)((ListBox)sender).DataSource)[((ListBox)sender).SelectedIndex];
                    Movie movie = _sqlinterface.MovieSearchByMovieID(selectedMovie.MovieID);
                    DisplayMovie(movie);
                }
                else if (datasource.GetType() == typeof(List<AssociatedMovie>))
                {
                    AssociatedMovie associatedMovie = ((List<AssociatedMovie>)((ListBox)sender).DataSource)[((ListBox)sender).SelectedIndex];
                    
                }
                else if (datasource.GetType() == typeof(List<AssociatedPerson>))
                {
                    AssociatedPerson associatedPerson = ((List<AssociatedPerson>)((ListBox)sender).DataSource)[((ListBox)sender).SelectedIndex];

                }
            }
        }

        private void uxAddPerson(object sender, EventArgs e) => new PersonEditor(_sqlinterface).ShowDialog();

        private void uxAddMovie(object sender, EventArgs e) => new MovieEditor(_sqlinterface).ShowDialog();
    }
}
