﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse
{
    public class NavigationControls
    {
        List<UserControl> userControlList = new List<UserControl>();
        Panel panel;

        public NavigationControls(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < userControlList.Count; i++)
            {
                userControlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControlList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < userControlList.Count())
            {
                userControlList[index].BringToFront();
            }
        }
    }
}
