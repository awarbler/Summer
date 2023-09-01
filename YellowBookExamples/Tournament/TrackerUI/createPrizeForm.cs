using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller )
        {
            InitializeComponent();
            callingForm = caller; // create a variable at the class level 
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) // if form is vaild
            {
                // create new prizeModel
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                // save model pass back to itself so it has the id in it
                GlobalConfig.Connection.CreatePrize(model); // not necessary model = GlobalConfig.Connection.CreatePrize(model);
                callingForm.PrizeComplete(model); // called our parent and here is the model only created if it is valid form
                // close our form 
                this.Close();

                //placeNameValue.Text = "";
                //placeNumberValue.Text = "";
                //prizeAmountValue.Text = "0";
                //prizePercentageValue.Text = "0";

            }
            else
            {
                MessageBox.Show
                    ("This form has invalid information, " +
                    "Please check it and try again.");
            }

        }

        // validate CreatePrizeForm - this runs all of the checks instead of
        // breaking out of the validate form and not completing out of the method
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber =
                int.TryParse(placeNumberValue.Text, out placeNumber);


            // place number int  and if it is an invalid number 
            if (placeNumberValidNumber == false) // or !placenumbervalidnumber 
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }

    }
}
