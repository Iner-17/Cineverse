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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateTime();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

        }

        private void Timer_tick(Object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
