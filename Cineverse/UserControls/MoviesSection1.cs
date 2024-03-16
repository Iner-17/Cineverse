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

    public partial class MoviesSection1 : UserControl
    {
        public MoviesSection1()
        {
            InitializeComponent();
        }

        private void btn_getTickets2_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
            addMovie.BringToFront();
        }

        private void btn_gt1_MouseEnter(object sender, EventArgs e)
        {
            btn_gt1.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt1.ForeColor = Color.Black;
        }

        private void btn_gt1_MouseLeave(object sender, EventArgs e)
        {
            btn_gt1.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt1.ForeColor = Color.White;
        }

        private void btn_gt2_MouseEnter(object sender, EventArgs e)
        {
            btn_gt2.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt2.ForeColor = Color.Black;
        }

        private void btn_gt2_MouseLeave(object sender, EventArgs e)
        {
            btn_gt2.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt2.ForeColor = Color.White;
        }

        private void btn_gt3_MouseEnter(object sender, EventArgs e)
        {
            btn_gt3.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt3.ForeColor = Color.Black;
        }

        private void btn_gt3_MouseLeave(object sender, EventArgs e)
        {
            btn_gt3.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt3.ForeColor = Color.White;
        }

        private void btn_gt4_MouseEnter(object sender, EventArgs e)
        {
            btn_gt4.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt4.ForeColor = Color.Black;
        }

        private void btn_gt4_MouseLeave(object sender, EventArgs e)
        {
            btn_gt4.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt4.ForeColor = Color.White;
        }

        private void btn_gt5_MouseEnter(object sender, EventArgs e)
        {
            btn_gt5.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt5.ForeColor = Color.Black;
        }

        private void btn_gt5_MouseLeave(object sender, EventArgs e)
        {
            btn_gt5.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt5.ForeColor = Color.White;
        }

        private void btn_gt6_MouseEnter(object sender, EventArgs e)
        {
            btn_gt6.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt6.ForeColor = Color.Black;
        }

        private void btn_gt6_MouseLeave(object sender, EventArgs e)
        {
            btn_gt6.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt6.ForeColor = Color.White;
        }

        private void btn_gt7_MouseEnter(object sender, EventArgs e)
        {
            btn_gt7.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt7.ForeColor = Color.Black;
        }

        private void btn_gt7_MouseLeave(object sender, EventArgs e)
        {
            btn_gt7.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt7.ForeColor = Color.White;
        }

        private void btn_gt8_MouseEnter(object sender, EventArgs e)
        {
            btn_gt8.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt8.ForeColor = Color.Black;
        }

        private void btn_gt8_MouseLeave(object sender, EventArgs e)
        {
            btn_gt8.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt8.ForeColor = Color.White;
        }

        private void btn_gt9_MouseEnter(object sender, EventArgs e)
        {
            btn_gt9.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt9.ForeColor = Color.Black;
        }

        private void btn_gt9_MouseLeave(object sender, EventArgs e)
        {
            btn_gt9.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt9.ForeColor = Color.White;
        }

        private void btn_addMovies_MouseEnter(object sender, EventArgs e)
        {
            btn_addMovies.BackColor = Color.FromArgb(31, 178, 198);
            btn_addMovies.ForeColor = Color.Black;
        }

        private void btn_addMovies_MouseLeave(object sender, EventArgs e)
        {
            btn_addMovies.BackColor = Color.FromArgb(20, 32, 32);
            btn_addMovies.ForeColor = Color.White;
        }

        private void btn_backk_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ParentForm is Dashboard dashboard)
            {
                // Display the Dashboard user control
                dashboard.navigationcontrols.Display(0);
            }
        }
    }

}
