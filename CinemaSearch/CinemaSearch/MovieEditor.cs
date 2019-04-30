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
    public partial class MovieEditor : Form
    {
        private SqlInterface _sqlInterface;
        private Movie _origionalMovie;

        private Person _director;

        private List<AssociatedPerson> _origionalActors;
        private List<AssociatedPerson> _actors;

        public MovieEditor(SqlInterface sqlInterface, Movie movie = null)
        {
            InitializeComponent();
            _sqlInterface = sqlInterface;
            _origionalMovie = movie;
            if (movie != null)
            {
                uxTitleTextBox.Text = movie.Title;
                uxRuntimeTextBox.Text = movie.Runtime == null ? string.Empty : movie.Runtime.Value.ToString();
                uxGenresTextBox.Text = movie.Genre == null ? string.Empty : movie.Genre;
                uxReleaseYearTextBox.Text = movie.ReleaseYear == null ? string.Empty : movie.ReleaseYear.Value.ToString();
                uxRatingTextBox.Text = movie.Rating == null ? string.Empty : movie.Rating.Value.ToString();
                if (movie.IsAdult == null)
                    uxAdultCheckBox.Checked = movie.IsAdult.Value;
                else
                    uxAdultCheckBox.Checked = false;

                if (movie.Director == null)
                    uxDirectorTextBox.Text = string.Empty;
                else
                {
                    _director = movie.Director;
                    uxDirectorTextBox.Text = movie.Director.ToString();
                    uxRemoveDirectorButton.Enabled = true;
                }

                if (movie.Actors != null)
                {
                    _origionalActors = movie.Actors;
                    uxRemoveActorButton.Enabled = true;
                }
                else
                    _origionalActors = new List<AssociatedPerson>();

                _actors = new List<AssociatedPerson>(_origionalActors);

                uxActorsListBox.DataSource = _actors;
                uxSubmitButton.Enabled = true;
                return;
            }
            _origionalActors = new List<AssociatedPerson>();
            _actors = new List<AssociatedPerson>();
            uxActorsListBox.DataSource = (List<AssociatedPerson>)_actors;
        }


        private void GetDiff(out List<AssociatedPerson> removed, out List<AssociatedPerson> updated)
        {
            removed = new List<AssociatedPerson>();
            updated = new List<AssociatedPerson>(_actors);

            foreach (AssociatedPerson po in _origionalActors)
            {
                bool found = false;
                foreach (AssociatedPerson p in updated)
                {
                    if (po.ID == p.ID && po.CharacterName == p.CharacterName)
                        updated.Remove(p);
                }
                if (found) continue;
                removed.Add(po);
            }
        }

        private void uxSubmitButton_Click(object sender, EventArgs e)
        {
            if (uxTitleTextBox.Text == string.Empty) return;

            int? runtime = null;
            if (uxRuntimeTextBox.Text != string.Empty) {
                if (!int.TryParse(uxRuntimeTextBox.Text, out int result)) return;
                runtime = new int?(result);
            }

            string genres = uxGenresTextBox.Text == string.Empty ? null : uxGenresTextBox.Text;

            int? releaseYear = null;
            if (uxReleaseYearTextBox.Text != string.Empty)
            {
                if (!int.TryParse(uxReleaseYearTextBox.Text, out int result)) return;
                releaseYear = new int?(result);
            }

            float? rating = null;
            if (uxRatingTextBox.Text != string.Empty)
            {
                if (!float.TryParse(uxReleaseYearTextBox.Text, out float result)) return;
                rating = new float?(result);
            }

            bool isAdult = uxAdultCheckBox.Checked;

            // insert/update movie
            int movieID;
            if (_origionalMovie != null) // update
            {
                movieID = _origionalMovie.MovieID;
                _sqlInterface.MovieUpdateMovie(movieID, uxTitleTextBox.Text, isAdult, runtime, releaseYear, null, null);
            }
            else // insert
            {
                movieID = _sqlInterface.MovieAddMovie(uxTitleTextBox.Text, isAdult, runtime, releaseYear, null, null);
                if (rating != null) _sqlInterface.MovieInsertNewRating(movieID, rating.Value);
            }
                

            

            if (_director != null)
            {
                _sqlInterface.MovieInsertDirector(movieID, _director.PersonID);
            }

            GetDiff(out List<AssociatedPerson> removed, out List<AssociatedPerson> updated);

            foreach (AssociatedPerson ap in removed)
            {
                _sqlInterface.MovieRemoveActor(movieID, ap.ID);
            }

            foreach (AssociatedPerson ap in updated)
            {
                _sqlInterface.MovieInsertActor(movieID, ap.ID, ap.CharacterName);
            }

            Close();
        }

        private void EnsureNotEmpty(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
                uxSubmitButton.Enabled = false;
            else
                uxSubmitButton.Enabled = true;
        }

        private void EnsureOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void EnsureOnlyDecimal(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar))) e.Handled = true;
        }

        private void uxSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ((TextBox)sender).Text != string.Empty)
            {
                List<Person> results = _sqlInterface.PersonSearch($"%{((TextBox)sender).Text }%", "%");
                uxSearchListBox.DataSource = results;
                if (results == null)
                {
                    uxAddDirectorButton.Enabled = false;
                    uxAddActorButton.Enabled = false;
                }
                else
                {
                    uxAddDirectorButton.Enabled = _director==null;
                    uxAddActorButton.Enabled = true;
                }
            }
        }

        private void uxAddDirectorButton_Click(object sender, EventArgs e)
        {
            _director = ((List<Person>)uxSearchListBox.DataSource)[uxSearchListBox.SelectedIndex];
            uxDirectorTextBox.Text = _director.Name;
            uxRemoveDirectorButton.Enabled = true;
        }

        private void uxAddActorButton_Click(object sender, EventArgs e)
        {

            Person person = ((List<Person>)uxSearchListBox.DataSource)[uxSearchListBox.SelectedIndex];
            TextDialog dialog = new TextDialog("Characters");
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                AssociatedPerson actor;
                if (dialog.Result == string.Empty)
                    actor = new AssociatedPerson(person.PersonID, person.Name, null, false);
                else
                    actor = new AssociatedPerson(person.PersonID, person.Name, dialog.Result, false);

                if (_actors.Contains(actor))
                    _actors[_actors.IndexOf(actor)] = actor;
                else
                    _actors.Add(actor);
                uxRemoveActorButton.Enabled = true;
            }
            uxActorsListBox.DataSource = null;
            uxActorsListBox.DataSource = _actors;
        }

        private void uxRemoveDirectorButton_Click(object sender, EventArgs e)
        {
            _director = null;
            uxDirectorTextBox.Text = string.Empty;
            uxRemoveDirectorButton.Enabled = false;
        }

        private void uxRemoveActorButton_Click(object sender, EventArgs e)
        {
            if(uxActorsListBox.SelectedIndex >= 0)
            {
                _actors.RemoveAt(uxActorsListBox.SelectedIndex);
                if (_actors.Count <= 0)
                    uxRemoveActorButton.Enabled = false;
            }
            uxActorsListBox.DataSource = null;
            uxActorsListBox.DataSource = _actors;
        }
    }
}
