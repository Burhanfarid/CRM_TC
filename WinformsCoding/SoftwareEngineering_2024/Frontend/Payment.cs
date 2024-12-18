﻿using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics.Metrics;
using SoftwareEngineering_2024.DB_connect;
using SoftwareEngineering_2024.utilities;

namespace SoftwareEngineering_2024
{
    public partial class Payment : Form
    {

        private userDAL userDAL = new userDAL();

        public Payment()
        {
            InitializeComponent();
            Opener.OpenSocialMediaLinks(FbLink, GmapLink, IgLink);
            cardNo_txt.KeyPress += Opener.Number_KeyPress;
            Cvv_txt.KeyPress += Opener.Number_KeyPress;

        }



        private void ProceedTqBt_Click(object sender, EventArgs e)
        {


            if (Opener.AreTextBoxesFilledAndCheckboxesChecked(this))
            {
                Opener.OpenForm(this, typeof(ThankYouForm));


                string str1 = CardName_txt.Text;
                string CardHolder_name = str1.ToUpper();  /* ToUpper will store always in upppercase of card holder name */
                string Card_no = cardNo_txt.Text;
                string Cvv = Cvv_txt.Text;
                string House_no = houseNo_txt.Text;
                string City = City_txt.Text;
                string State = State_txt.Text;
                string Country = Country_txt.Text;
                string Street = Street_txt.Text;
                string Citycode = City_txt.Text;
                string Exp_date = ExpDate_txt.Text;




                bool isRegistered = userDAL.Payment_infoToDatabse(CardHolder_name, Card_no, Cvv, House_no, City, State, Country, Street, Citycode, Exp_date);

                if (isRegistered)
                {
                    //this will count this form if the form is completed then it will store true
                    FormTracker.StepsCompleted[4] = true;
                }

            }

        }

        private void PreviousPageBt_Click(object sender, EventArgs e)
        {
            Opener.GoBack(this);
            FormTracker.StepsCompleted[4] = false;
            userDAL.DeleteUserByMEmid();
        }

        
    }
}
