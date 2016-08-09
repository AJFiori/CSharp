using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCensusReport
{
    public partial class HelpForm : Form
    {       
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            lblPg2.Text = "Upon loading the program you will be greeted with the form to submit records into the database. \n"
                         + "You will have to fill out all of the fields with information that cannot exceed the maximum \n" 
                         + "number of beds for each unit. \n\n The maximum number of beds for each unit are: \n\n"
                         + "            -ICU [9 Beds] \n" + "            -T2 [28 Beds] \n" + "            -PEDI [28 Beds] \n" + "            -T4 [29 Beds] \n" + "            -6ACU [10 Beds] \n" + "            -TBC [10 Beds] \n" + "            -BHU [15 Beds] \n\n"
                         + "Whatever number you put in for the Current Census for each unit, the number \n of available beds "
                         + "will change dynamically to the proper amount of remaining/available beds.";
            pnlPage1.SendToBack();
            pnlPage2.BringToFront();
            btnHelpExit.Show();
            btnNext.Hide();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {          
            
            lblHelpHeader.Text = "Getting Started...";
            lblPg1.Text = "If you are having trouble figuring out how the program works, please refer to the next few pages."
                                + "\n\n\n\n\n\n Click 'Next' to read further.";
            btnHelpExit.Hide();
        }

        private void btnHelpExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
