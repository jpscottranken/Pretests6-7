using System;
using System.Windows.Forms;

/*
 *		1.	Write a C# GUI app that converts either 
 *			a temperature inputted in Fahrenheit to 
 *			Celsius or a temperature inputted in
 *			Celsius to Fahrenheit.:
 *
 *		Verify that either input is:
 *		
 *		a)`Not empty. 
 *		b)`Not non-numeric.
 *		c)`Within range.
 *
 *		Create constants MINFAHR (-212), MAXFAHR (212),
 *		MINCELSIUS (-100), MAXCELSIUS (100).
 *
 *		Here are the conversion formulas:
 *
 *		celsius    = (fahrenheit - 32) / 1.8
 *		fahrenheit = (celsius * 1.8) + 32
 *
 *		a) 	For both programs, set the Tab Order, 
 *			AcceptButton, CancelButton, and Start
 *			Position accordingly.
 *
 *		b) 	For both programs, change the name of 
 *			the form accordingly and the form text
 *			as well.  
 *
 *		c) 	For both programs, create a program 
 *			prologue at the beginning of the code. 
 *
 *		d) 	For both programs, for any numeric values
 *			inputted, verify that each value is not
 *			empty, not non-numeric, and not out of 
 *			range.
 *
 *		e) 	NEW: Modularize each program.
 *
 *			Try to have no executable code in any 
 *			control except for calls to user-written 
 *			methods.
 *
 *		f)	NEW: Add generic validation handling to
 *			the temperature conversion program and 
 *			exception handling to the batting average
 *			program. 
 */

namespace Pretest6_7_1
{
    public partial class frmTemperatureConverter : Form
    {
        //  Declare and initialize program constants
        const int MINFAHR    = -212;
        const int MAXFAHR    =  212;
        const int MINCELSIUS = -100;
        const int MAXCELSIUS =  100;

        public frmTemperatureConverter()
        {
            InitializeComponent();
        }

        private void btnConvertFToC_Click(object sender, EventArgs e)
        {
            if (IsValidFahrenheit())
            {
                PerformFToCConversion();
            }
        }

        private void btnConvertCToF_Click(object sender, EventArgs e)
        {
            if (IsValidCelsius())
            {
                PerformCToFConversion();
            }
        }

        private bool IsValidFahrenheit()
        {
            bool success = true; 
            string errorMessage = "";

            // Validate the Fahrenheit text box
            errorMessage += IsPresent(txtFahrTemp.Text, "Fahrenheit Temperature");
            errorMessage += IsDecimal(txtFahrTemp.Text, "Fahrenheit Temperature");
            errorMessage += IsWithinRange(txtFahrTemp.Text, "Fahrenheit Temperature",
                                          MINFAHR, MAXFAHR);

            if (errorMessage != "")
            {
                success = false; 
                ShowErrorMessage(errorMessage, "Entry Error");
            }

            return success;
        }

        private void PerformFToCConversion()
        {
            decimal fahrenheit = Convert.ToDecimal(txtFahrTemp.Text.Trim());
            decimal celsius    = 0m;

            celsius = (fahrenheit - 32m) / 1.8m;

            txtCelTemp.Text = ($"{celsius:n2}");
        }

        private bool IsValidCelsius()
        {
            bool success = true; 
            string errorMessage = "";

            // Validate the Celsius text box
            errorMessage += IsPresent(txtCelTemp.Text, "Celsius Temperature");
            errorMessage += IsDecimal(txtCelTemp.Text, "Celsius Temperature");
            errorMessage += IsWithinRange(txtCelTemp.Text, "Celsius Temperature",
                                          MINCELSIUS, MAXCELSIUS);

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "Entry Error");
            }

            return success;
        }

        private void PerformCToFConversion()
        {
            decimal celsius    = Convert.ToDecimal(txtCelTemp.Text.Trim());
            decimal fahrenheit = 0m;

            fahrenheit = (celsius * 1.8m) + 32m;

            txtFahrTemp.Text = ($"{fahrenheit:n2}");
        }

        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }

            return msg;
        }

        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }

            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                }
            }

            return msg;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFahrTemp.Text = "";
            txtCelTemp.Text  = "";
            txtFahrTemp.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
