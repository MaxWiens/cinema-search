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
            _origionalMovie = movie;;
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

            int? runtime;
            if (uxRuntimeTextBox.Text != string.Empty) {
                if (!int.TryParse(uxRuntimeTextBox.Text, out int result)) return;
                runtime = new int?(result);
            }

            string genres = uxGenresTextBox.Text == string.Empty ? null : uxGenresTextBox.Text;

            int? releaseYear;
            if (uxReleaseYearTextBox.Text != string.Empty)
            {
                if (!int.TryParse(uxReleaseYearTextBox.Text, out int result)) return;
                releaseYear = new int?(result);
            }

            float? rating;
            if (uxRatingTextBox.Text != string.Empty)
            {
                if (!float.TryParse(uxReleaseYearTextBox.Text, out float result)) return;
                rating = new float?(result);
            }

            bool isAdult = uxAdultCheckBox.Checked;

            // insert/update movie

            if (_director != null)
            {
                // insert director
            }

            GetDiff(out List<AssociatedPerson> removed, out List<AssociatedPerson> updated);
            
            if (removed.Count != 0)
            {
                // remove actors
            }

            if (updated.Count != 0)
            {
                // update/insert actors
            }
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
                    uxAddDirectorButton.Enabled = !(_director==null);
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

            Person actor = ((List<Person>)uxSearchListBox.DataSource)[uxSearchListBox.SelectedIndex];
            //dialog
            //if (_actors.Contains())
            //_actors.Add
            //_actors = 
        }
    }
}
