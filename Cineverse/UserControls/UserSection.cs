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

        private void UserSection_Load(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMMM d, yyyy");

            lbl_date.Text = formattedDate;

            DateTime dateTime = DateTime.UtcNow.Date;
        }

        
        
    }
}
