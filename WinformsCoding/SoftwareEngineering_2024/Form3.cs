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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            FbLink.Click += Opener.OpenFacebook;
            GmapLink.Click += Opener.OpenGoogleMaps;
            IgLink.Click += Opener.OpenInstagram;
            LogInLink.Click += LogInLink_LinkClicked;
        }


        private void LogInLink_LinkClicked(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(LoginForm));
        }

        private void ProceedIntBt_Click(object sender, EventArgs e)
        {
            Opener.OpenForm(this, typeof(InterestDptForm));
        }

        private void TCLogo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {

        }
    }
}