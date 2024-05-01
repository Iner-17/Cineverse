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
    public partial class ConfirmedPaymentSection : UserControl
    {
        public ConfirmedPaymentSection()
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
    }
}
