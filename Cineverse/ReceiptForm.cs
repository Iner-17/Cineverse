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
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void btn_backToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard1 = (Dashboard)Application.OpenForms["Dashboard"];
            dashboard1.btn_dashboard_Click(this, EventArgs.Empty);
            dashboard1.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void btn_print_MouseEnter(object sender, EventArgs e)
        {
            btn_print.BackColor = Color.FromArgb(31, 178, 198);
            btn_print.ForeColor = Color.Black;
        }

        private void btn_print_MouseLeave(object sender, EventArgs e)
        {
            btn_print.BackColor = Color.FromArgb(20, 32, 32);
            btn_print.ForeColor = Color.White;
        }
    }


}
