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
    public partial class MovieEditor : Form
    {
        private SqlInterface _sqlInterface;
        private Movie _movie;

        public MovieEditor(SqlInterface sqlInterface, Movie movie = null)
        {
            InitializeComponent();
            _sqlInterface = sqlInterface;
            _movie = movie;

            if (_movie != null)
            {
                //ux.Text = person.Name;
                //uxBirthYear.Text = person.BirthYear == null ? string.Empty : person.BirthYear.Value.ToString();
                //uxSubmitButton.Enabled = true;
            }
        }
    }
}
