using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Temperature_Converter.docs.LengthConversion
{
    public partial class Length_Converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LengthConvertButton_Click(object sender, EventArgs e)
        {
            string Centimeter = "Centimeter";
            string Inches = "Inches";
            string Meter = "Meter";
            string kilometer = "kilometer";
            string Mile = "Mile";


            var inputLeft = inputbox.Text;
            var inUnit = lengthDropDownList1.SelectedValue;

            var outUnit = LengthDropDownList2.SelectedValue;

            if (inUnit == outUnit)
            {
                resultbox.Text = inputLeft;
            }

            if (inUnit == Centimeter && outUnit == Centimeter)
            {
                inputbox.Text = ((((double.Parse(inputLeft) * 9) / 5) + 32).ToString());
            }

            if (inUnit == Centimeter && outUnit == Inches)
            {
                resultbox.Text = ((((double.Parse(inputLeft))  * 25) / 64)).ToString();
            }

            if (inUnit == Centimeter && outUnit == Meter)
            {
                resultbox.Text = ((double.Parse(inputLeft) /100).ToString());
            }

            if (inUnit == Centimeter && outUnit == kilometer)
            {
                resultbox.Text = ((double.Parse(inputLeft) /1000).ToString());
            }

            if (inUnit == Inches && outUnit == Centimeter)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 127 / 50) .ToString());
            }

            if (inUnit == Inches && outUnit == Meter)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 254 / 10000) .ToString()); 
            }

            if (inUnit == Inches && outUnit == kilometer)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 254 / 100000).ToString());
            }
            if (inUnit == Inches && outUnit == Mile)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 1578 / 100000000).ToString());
            }
            if (inUnit == Meter && outUnit == Inches)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 3937 / 100).ToString());
            }
            if (inUnit == Meter && outUnit == Centimeter)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 100).ToString());
            }
            if (inUnit == Meter && outUnit == kilometer)
            {
                resultbox.Text = ((double.Parse(inputLeft) / 1000).ToString());
            }

            if (inUnit == kilometer && outUnit == Centimeter)
            {
                resultbox.Text = ((double.Parse(inputLeft) *10000).ToString());
            }
            if (inUnit == kilometer && outUnit == Meter)
            {
                resultbox.Text = ((double.Parse(inputLeft) *1000).ToString());
            }
            if (inUnit == kilometer && outUnit == Mile)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 5/8).ToString());
            }
            if (inUnit == kilometer && outUnit == Inches)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 393700787 / 10000).ToString());
            }
        }

        protected void inputbox_TextChanged(object sender, EventArgs e)
        {
            string Centimeter = "Centimeter";
            string Inches = "Inches";
            string Meter = "Meter";
            string kilometer = "kilometer";
            string Mile = "Mile";


            var inputLeft = inputbox.Text;
            var inUnit = lengthDropDownList1.SelectedValue;

            var outUnit = LengthDropDownList2.SelectedValue;

            if (inUnit == outUnit)
            {
                resultbox.Text = inputLeft;
            }

            if (inUnit == Centimeter && outUnit == Mile)
            {
                inputbox.Text = ((((double.Parse(inputLeft) * 621371) / 100000000000)).ToString());
            }

            if (inUnit == Centimeter && outUnit == Inches)
            {
                resultbox.Text = ((((double.Parse(inputLeft)) * 25) / 64)).ToString();
            }

            if (inUnit == Centimeter && outUnit == Meter)
            {
                resultbox.Text = ((double.Parse(inputLeft) / 100).ToString());
            }

            if (inUnit == Centimeter && outUnit == kilometer)
            {
                resultbox.Text = ((double.Parse(inputLeft) / 1000).ToString());
            }

            if (inUnit == Inches && outUnit == Centimeter)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 127 / 50).ToString());
            }

            if (inUnit == Inches && outUnit == Meter)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 254 / 10000).ToString());
            }

            if (inUnit == Inches && outUnit == kilometer)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 254 / 100000).ToString());
            }
            if (inUnit == Inches && outUnit == Mile)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 1578 / 100000000).ToString());
            }
            if (inUnit == Meter && outUnit == Inches)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 3937 / 100).ToString());
            }
            if (inUnit == Meter && outUnit == Centimeter)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 100).ToString());
            }
            if (inUnit == Meter && outUnit == kilometer)
            {
                resultbox.Text = ((double.Parse(inputLeft) / 1000).ToString());
            }
            if (inUnit == Meter && outUnit == Mile)
            {
                resultbox.Text = ((double.Parse(inputLeft) / 1000).ToString());
            }
            if (inUnit == kilometer && outUnit == Centimeter)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 10000).ToString());
            }
            if (inUnit == kilometer && outUnit == Meter)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 1000).ToString());
            }
            if (inUnit == kilometer && outUnit == Mile)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 621371 / 1000000000).ToString());
            }
            if (inUnit == kilometer && outUnit == Inches)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 393700787 / 10000).ToString());
            }
            if (inUnit == kilometer && outUnit == Mile)
            {
                resultbox.Text = ((double.Parse(inputLeft) * 8 / 5).ToString());
            }
        }

        
    }
}