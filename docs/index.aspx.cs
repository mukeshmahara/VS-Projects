using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temperature_Converter.docs

{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Convert(object sender, EventArgs e)
        {

            string Celcius = "Celcius";
            string Farenheit = "Farenheit";
            string Kelvin = "Kelvin";

            var inputLeft = txtLeftBox.Text;
            var inUnit = DropDownList1.SelectedValue;

            var outUnit = DropDownList2.SelectedValue;

            if (inUnit == outUnit)
            {
                txtRightBox.Text = inputLeft;
            }

            if (inUnit == Celcius && outUnit == Farenheit)
            {
                txtRightBox.Text = ((((double.Parse(inputLeft) * 9) / 5) + 32).ToString());
            }

            if (inUnit == Farenheit && outUnit == Celcius)
            {
                txtRightBox.Text = (((((double.Parse(inputLeft))-32) * 5) / 9) ).ToString();
            }

            if (inUnit == Celcius && outUnit == Kelvin)
            {
                txtRightBox.Text = ((double.Parse(inputLeft) + 273).ToString());
            }

            if (inUnit == Kelvin && outUnit == Celcius)
            {
                txtRightBox.Text = ((double.Parse(inputLeft) - 273).ToString());
            }

            if (inUnit == Kelvin && outUnit == Farenheit)
            {
                txtRightBox.Text = (((double.Parse(inputLeft) * 9 / 5) - 459.67).ToString());
            }

            if (inUnit == Farenheit && outUnit == Kelvin)
            {
                txtRightBox.Text = (((double.Parse(inputLeft) * 9 / 5) + 459.67).ToString());
            }

        }

        protected void txtLeftBox_TextChanged(object sender, EventArgs e)
        {
            string Celcius = "Celcius";
            string Farenheit = "Farenheit";
            string Kelvin = "Kelvin";

            var inputLeft = txtLeftBox.Text;
            var inUnit = DropDownList1.SelectedValue;

            var outUnit = DropDownList2.SelectedValue;

            if (inUnit == outUnit)
            {
                txtRightBox.Text = inputLeft;
            }

            if (inUnit == Celcius && outUnit == Farenheit)
            {
                txtRightBox.Text = ((((double.Parse(inputLeft) * 9) / 5) + 32).ToString());
            }

            if (inUnit == Farenheit && outUnit == Celcius)
            {
                txtRightBox.Text = (((((double.Parse(inputLeft)) - 32) * 5) / 9)).ToString();
            }

            if (inUnit == Celcius && outUnit == Kelvin)
            {
                txtRightBox.Text = ((double.Parse(inputLeft) + 273).ToString());
            }

            if (inUnit == Kelvin && outUnit == Celcius)
            {
                txtRightBox.Text = ((double.Parse(inputLeft) - 273).ToString());
            }

            if (inUnit == Kelvin && outUnit == Farenheit)
            {
                txtRightBox.Text = (((double.Parse(inputLeft) * 9 / 5) - 459.67).ToString());
            }

            if (inUnit == Farenheit && outUnit == Kelvin)
            {
                txtRightBox.Text = (((double.Parse(inputLeft) * 9 / 5) + 459.67).ToString());
            }
        }
    }
}