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
    public partial class MovieViewer : Form
    {
        private SqlInterface _sqlinterface;
        private object _currentlyDisplayed;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";

        public MovieViewer()
        {
            InitializeComponent();

            

            _sqlinterface = new SqlInterface(connectionString);
            DatabaseInit.InitalizeDatabase(connectionString);
            uxResetInfo();
            uxSearchForComboBox.SelectedIndex = 0;
            uxSearchForComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void uxSearchEvent(object sender, EventArgs e)
        {
            string title = uxMovieSearchbox.Text;
            string genre = uxGenreTextBox.Text;
            if (uxSearchForComboBox.SelectedIndex == 0) { // searching for movie
                List<Movie> results = _sqlinterface.MovieSearch(title, genre);
                uxMovieListBox.DataSource = results;
            } else { // searching for person
                List<Person> results = _sqlinterface.PersonSearch(title, genre);
                uxMovieListBox.DataSource = results;
            }
            
        }

        private void DisplayPerson(Person person)
        {
            uxResetInfo();
            uxEditButton.Enabled = true;
            uxDataListLabel.Text = "Associated Movies:";

            _currentlyDisplayed = person;
            uxDataName.Text = person.Name;

            if(person.BirthYear.HasValue)
                uxData1.Text = "Born: " + person.BirthYear.Value;

            // associated movies
            uxDatalistBox.DataSource = person.Movies;
        }

        private void DisplayMovie(Movie movie)
        {
            uxResetInfo();
            uxEditButton.Enabled = true;
            uxDataListLabel.Text = "Actors:";

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
            DisplayPerson(_sqlinterface.MoviePersonFromID(((Movie)_currentlyDisplayed).Director.PersonID));
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
                if (((ListBox)sender).DataSource == null) return;

                object datasource = ((ListBox)sender).DataSource;
                if (datasource.GetType() == typeof(List<Movie>))
                {
                    Movie selectedMovie = ((List<Movie>)((ListBox)sender).DataSource)[((ListBox)sender).SelectedIndex];
                    Movie movie = _sqlinterface.MovieSearchByMovieID(selectedMovie.MovieID);
                    DisplayMovie(movie);
                }
                else if (datasource.GetType() == typeof(List<Person>))
                {
                    Person selectedPerson = ((List<Person>)((ListBox)sender).DataSource)[((ListBox)sender).SelectedIndex];
                    Person person = _sqlinterface.MoviePersonFromID(selectedPerson.PersonID);
                    DisplayPerson(person);
                }
                else if (datasource.GetType() == typeof(List<AssociatedMovie>))
                {
                    AssociatedMovie associatedMovie = ((List<AssociatedMovie>)((ListBox)sender).DataSource)[((ListBox)sender).SelectedIndex];
                    Movie movie = _sqlinterface.MovieSearchByMovieID(associatedMovie.ID);
                    DisplayMovie(movie);
                }
                else if (datasource.GetType() == typeof(List<AssociatedPerson>))
                {
                    AssociatedPerson associatedPerson = ((List<AssociatedPerson>)((ListBox)sender).DataSource)[((ListBox)sender).SelectedIndex];
                    Person person = _sqlinterface.MoviePersonFromID(associatedPerson.ID);
                    DisplayPerson(person);
                }
            }
        }

        private void uxAddPerson(object sender, EventArgs e) => new PersonEditor(_sqlinterface).ShowDialog();

        private void uxAddMovie(object sender, EventArgs e) => new MovieEditor(_sqlinterface).ShowDialog();

        private void uxEditButton_Click(object sender, EventArgs e)
        {
            if (_currentlyDisplayed.GetType() == typeof(Movie))
            {
                new MovieEditor(_sqlinterface, (Movie)_currentlyDisplayed).ShowDialog();
            }
            else if (_currentlyDisplayed.GetType() == typeof(Person))
            {
                new PersonEditor(_sqlinterface, (Person)_currentlyDisplayed).ShowDialog();
            }
        }
        private void populateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = uxBrowseForDataDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                try
                {
                    string[] files = Directory.GetFiles(uxBrowseForDataDialog.SelectedPath, "*.tsv");
                    if(files.Length < 8)
                    {
                        MessageBox.Show("Invalid path. Some data files (.tsv) weren't found.");
                    } else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DatabaseInit.CreateTables(connectionString);
                        DatabaseInit.PopulateDatabase(connectionString, uxBrowseForDataDialog.SelectedPath);
                        Cursor.Current = Cursors.Default;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            } 
        }
    }
}
