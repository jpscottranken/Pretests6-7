using System;
using System.Windows.Forms;

/*
 *		2.	In baseball, a player's average 
 *		    is calculated by dividing hits 
 *		    by at bats.  
 *		    
 *		    For example, a player with 4 hits 
 *		    in 10 at bats has an average of 
 *		    .400, typically stated as a 400 
 *		    average.
 *		    
 *		    Write a C# GUI windows forms program 
 *		    that lets the user input hits and at 
 *		    bats.  From there, calculate the 
 *		    associated batting average.
 *		    
 *		    Also, keep track of the highest batting 
 *		    average, the lowest batting average, and 
 *		    the total number of averages that have 
 *		    been calculated.  
 *		    
 *		    Store these are read-only textboxes.
 *
 *		For hits & at bats, use exception handling 
 *		to verify that:
 *		
 *		a) `The value inputted is not empty.
 *		b) `The value inputted is not non-numeric.
 *		c) `The value inputted is 0 or more.
 *		d) `For hits, the value is <= the value 
 *		    for at bats.
 *
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

namespace Pretest6_7_2
{
    public partial class frmBattingAverage : Form
    {
        //  Declare and initialize class variable
        static int totalAvgs = 0;
        static decimal highAvg = 0m;
        static decimal lowAvg = 0m;
        static decimal avg = 0m;

        public frmBattingAverage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int atBats = Convert.ToInt32(txtAtBats.Text.Trim());
                int hits = Convert.ToInt32(txtHits.Text.Trim());

                //  Check error conditions
                if (hits > atBats || hits < 0 || atBats < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                avg = (decimal)hits / (decimal)atBats;
                totalAvgs++;
                txtTotalNumberAverages.Text = ($"{totalAvgs}");
                txtAverage.Text = ($"{avg:n3}");

                if (totalAvgs == 1)
                {
                    lowAvg = avg;
                    highAvg = avg;
                    txtLowestAverage.Text = ($"{avg:n3}");
                    txtHighestAverage.Text = ($"{avg:n3}");
                }
                else if (totalAvgs > 1)
                {
                    if (avg < lowAvg)
                    {
                        lowAvg = avg;
                        txtLowestAverage.Text = ($"{lowAvg:n3}");
                    }
                    else if (avg > highAvg)
                    {
                        highAvg = avg;
                        txtHighestAverage.Text = ($"{highAvg:n3}");
                    }
                }
            }
            catch (ArgumentNullException ane)
            {
                ShowErrorMessage("System Message:\t" + ane.Message + "\n\n" +
                                 "You Must Enter A Value For Both At Bats and Hits",
                                 "ARGUMENTNULLEXCEPTION");
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                ShowErrorMessage("System Message:\t" + aoore.Message + "\n\n" +
                                 "You Must Enter A Value >= 0 For Both At Bats and Hits",
                                 "ARGUMENTOUTOFRANGEEXCEPTION");
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message + "\n\n" +
                                 "You Must Enter A Value >= 0 For Both At Bats and Hits",
                                 "FORMATEXCEPTION");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAtBats.Text = "";
            txtHits.Text = "";
            txtAverage.Text = "";
            txtAtBats.Focus();
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
