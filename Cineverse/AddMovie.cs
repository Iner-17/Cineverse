using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            this.Close();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }
    }
}
