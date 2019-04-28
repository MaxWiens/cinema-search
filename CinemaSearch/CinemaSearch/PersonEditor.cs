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
    public partial class PersonEditor : Form
    {
        private SqlInterface _sqlInterface;
        private Person _person;

        public PersonEditor(SqlInterface sqlInterface, Person person = null)
        {
            InitializeComponent();
            _sqlInterface = sqlInterface;
            _person = person;

            if (_person != null)
            {
                uxNameTextBox.Text = person.Name;
                uxBirthYear.Text = person.BirthYear == null ? string.Empty: person.BirthYear.Value.ToString();
                uxSubmitButton.Enabled = true;
            }
        }

        private void uxSubmitButtonClick(object sender, EventArgs e)
        {
            if (uxNameTextBox.Text != String.Empty)
            {
                // adding new Person
                if (_person == null)
                {
                    string name = uxNameTextBox.Text;

                    int? birthYear = uxBirthYear.Text == string.Empty ? null : new int?(int.Parse(uxNameTextBox.Text));

                    _sqlInterface.MovieAddPerson(name, birthYear);

                }
                // editing Person
                else
                {
                    string name = uxNameTextBox.Text == string.Empty ? null : uxNameTextBox.Text;
                    int? birthyear;
                    if (uxBirthYear.Text == string.Empty)
                        birthyear = null;
                    else
                    {
                        if (!int.TryParse(uxBirthYear.Text, out int year))
                        {
                            MessageBox.Show("Failed to submit");
                            return;
                        }
                        birthyear = new int?(year);
                    }

                    //_sqlInterface.MovieUpdatePerson(_personID.Value, name, birthYear);
                }
            }
        }

        private void uxNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxNameTextBox.Text == string.Empty)
                uxSubmitButton.Enabled = false;
            else
                uxSubmitButton.Enabled = true;
        }

        private void uxBirthYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
