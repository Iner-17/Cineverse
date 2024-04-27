using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse.UserControls
{
    public partial class UserSection : UserControl
    {
        public UserSection()
        {
            InitializeComponent();
        }

        private void btn_timeOut_MouseEnter(object sender, EventArgs e)
        {
            btn_timeOut.BackColor = Color.DarkRed;
            btn_timeOut.ForeColor = Color.White;
        }

        private void btn_timeOut_MouseLeave(object sender, EventArgs e)
        {
            btn_timeOut.BackColor = Color.FromArgb(20, 32, 32);
            btn_timeOut.ForeColor = Color.White;
        }
    }
}
