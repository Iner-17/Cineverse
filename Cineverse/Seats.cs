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
    public partial class Seats : Form
    {

        Color selectedColor = Color.FromArgb(225, 48, 48);
        Color availableColor = Color.FromArgb(217, 217, 217);
        Color bookedColor = Color.FromArgb(31, 178, 198);
        Color glowColor = Color.FromArgb(100, 100, 100);
        public Seats()
        {
            InitializeComponent();
            SelectingSeats();
        }
     
        private void SelectingSeats()
        {
            
            for (char row = 'A'; row <= 'J'; row++)
            {
                for (int seatNum = 1; seatNum <= 20; seatNum++)
                {
                    string seatPanelName = $"{row}{seatNum}";

                    Control[] foundControls = Controls.Find(seatPanelName, true);
                    if (foundControls.Length > 0 && foundControls[0] is Panel seatPanel)
                    {
                        seatPanel.Click += (sender, e) =>
                        {
                            if (seatPanel.BackColor == bookedColor)
                            {
                                return;
                            }
                            seatPanel.BackColor = (seatPanel.BackColor == selectedColor) ? availableColor : selectedColor;
                        if (seatLists.Text == "")
                        {
                            seatLists.Text += seatPanelName;

                        }
                        else if (seatLists.Text == seatPanelName)
                        {
                            seatLists.Text = "";
                        }
                        else if (seatLists.Text != "" && seatPanel.BackColor == selectedColor)
                            {

                                seatLists.Text += ", " + seatPanelName;
                                
                            }
                            else if (seatPanel.BackColor == availableColor) 
                            {
                                
                                seatLists.Text = seatLists.Text.Replace(", " + seatPanelName, "");
                            }
                            
                        };
                        seatPanel.MouseEnter += (sender, e) =>
                        {
                            if (seatPanel.BackColor != bookedColor && seatPanel.BackColor != selectedColor)
                            {
                                seatPanel.BackColor = glowColor;
                            }
                                
                        };
                        seatPanel.MouseLeave += (sender, e) =>
                        {
                            if (seatPanel.BackColor != bookedColor && seatPanel.BackColor != selectedColor)
                            {
                                seatPanel.BackColor = availableColor;
                            }
                        };
                        lbl_clearAll.MouseClick += (sender, e) =>
                        {
                            if (seatPanel.BackColor == selectedColor)
                            {
                                seatPanel.BackColor = availableColor;
                            }
                            seatLists.Text = "";
                        };
                    }
                }
            }
            
        }
        


        private void panel5_Click(object sender, EventArgs e)
        {
            Seats seat = new Seats();
            this.Close();

            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            this.Close();
        }

        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.FromArgb(31, 178, 198);
            btn_back.ForeColor = Color.Black;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.FromArgb(20, 32, 32);
            btn_back.ForeColor = Color.White;
        }

        private void btn_payment_MouseEnter(object sender, EventArgs e)
        {
            btn_payment.BackColor = Color.FromArgb(31, 178, 198);
            btn_payment.ForeColor = Color.Black;
        }

        private void btn_payment_MouseLeave(object sender, EventArgs e)
        {
            btn_payment.BackColor = Color.FromArgb(20, 32, 32);
            btn_payment.ForeColor = Color.White;
        }

        private void lbl_clearAll_MouseEnter(object sender, EventArgs e)
        {
            lbl_clearAll.ForeColor = Color.Red;
        }

        private void lbl_clearAll_MouseLeave(object sender, EventArgs e)
        {
            lbl_clearAll.ForeColor= Color.White;
        }

        
    }
}
