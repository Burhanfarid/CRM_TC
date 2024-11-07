﻿using System;
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
    public partial class ThankYouForm : Form
    {
        public ThankYouForm()
        {
            InitializeComponent();
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
        }

        private void ThankyouLoginBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }
    }
}
