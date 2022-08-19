using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivisionDecVsMod___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 04/11/2021
    //Goal: Demonstrate division using decimal and modulo division
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //VARIABLES
            //Input Variables
            decimal dividend = 0;
            decimal divisor = 0;
            bool tryParseResult;
            //Output Variables
            int myQuotient = 0, myRemainder = 0;
            decimal decimalOtpt = 0;
            //INPUT
            //Get dividend and divisor and verify numeric value from user
            //Verify dividend is numeric
            tryParseResult = decimal.TryParse(dividendInpt.Text, out dividend);
            if (tryParseResult == false)
            { MessageBox.Show("Error: Please enter a numeric dividend.");
                return; }
            //Verify divisor is numeric
            tryParseResult = decimal.TryParse(divisorInpt.Text, out divisor);
            if (tryParseResult == false || divisor == 0)
            { MessageBox.Show("Error: Please enter a numeric divisor that isn't 0.");
                return;
            }
            //CALCULATIONS
            //Calculate Quotient
            myQuotient = (int)dividend / (int)divisor;
            //Calculate Remainder
            myRemainder = (int)dividend % (int)divisor;
            //Calculate Decimal value
            decimalOtpt = dividend / divisor;

            //OUTPUT
            //Display Quotient
            quotientOtpt.Text = myQuotient.ToString();
            //Display Remainder
            remainderOtpt.Text = myRemainder.ToString();
            //Display Decimal value
            decOtpt.Text = decimalOtpt.ToString("n4");

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear input textboxes
            dividendInpt.Text = "";
            divisorInpt.Text = "";
            //Clear Output textboxes
            quotientOtpt.Text = "";
            remainderOtpt.Text = "";
            decOtpt.Text = "";
        }
    }
}
