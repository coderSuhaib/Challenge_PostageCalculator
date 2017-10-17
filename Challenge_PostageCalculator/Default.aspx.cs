using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_PostageCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
        }

 
        protected void getCalculation(object sender, EventArgs e)
        {
            widthTextBox.Focus();
            heightTextBox.Focus();
            lengthTextBox.Focus();
            getTotal();
        }
                
        private void getTotal()
        {
            // check that all the required boxes have been filled out and the radio button has been checked
            if (!requirementsMet()) return;

            // get volume
            double volume = 0;
            if (!tryGetVolume(out volume)) return;

            // get the shipping muiltiplier to calculate the shipping methode with the volume 
            double shippingMultiplier = getShippingMultiplier();

            // calculate the totale cost of the shipping
            double cost = volume * shippingMultiplier;

            // show the total cost in the result label
            resultLabel.Text = string.Format("Your parcel will cost {0:C} to ship.", cost);

        }


        private bool requirementsMet()
        {
            if (!airRadioBtn.Checked
                && !groundRadioBtn.Checked
                && !nextDayRadioBtn.Checked)
                return false;

            if (widthTextBox.Text.Trim().Length == 0
                || heightTextBox.Text.Trim().Length == 0)
                return false;
            return true;
        }



        private bool tryGetVolume(out double volume)
        {
            volume = 0;
            double width = 0;
            double height = 0;
            double length = 0;

            if (!double.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!double.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!double.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;

        }

        private double getShippingMultiplier()
        {
            if (groundRadioBtn.Checked) return .15;
            else if (airRadioBtn.Checked) return .25;
            else if (nextDayRadioBtn.Checked) return .45;
            else return 0;
        }
                
    }
}