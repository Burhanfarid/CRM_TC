﻿using SoftwareEngineering_2024.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_2024
{
    public partial class UserEventsForm : Form
    {
        private showTables showTables = new showTables();
        public UserEventsForm()
        {
            InitializeComponent();
            FormOpener.OpenUserDashboardPages(HomeBt, MembershipsBt, EventsBt, MyBookingsBt, SpaceBt, QueryBt);
        }

        private void ViewEventsLinkBt_Click(object sender, EventArgs e)
        {
            Opener.OpenLink("https://www.togetherculture.com/events");
        }

        private void UserEventsForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * \r\nFROM events \r\nWHERE event_date = CURDATE();\r\n";
            showTables.GRIDVIEW(TodayEventsDg, query);
            string query1 = "SELECT * \r\nFROM events \r\nWHERE event_date >= CURDATE();\r\n";
            showTables.GRIDVIEW(UpEventsDg, query1);

        }
    }
}
