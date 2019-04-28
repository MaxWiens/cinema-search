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
        private int? _movieID;

        public MovieEditor(SqlInterface sqlInterface, int? movieID = null)
        {
            InitializeComponent();
            _sqlInterface = sqlInterface;
            _movieID = movieID;
        }
    }
}
