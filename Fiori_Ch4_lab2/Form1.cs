using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiori_Ch4_lab2
{
    public partial class AreaandPerimeter : Form
    {
        public AreaandPerimeter()
        {
            // creates the ability to calculate program by using "Enter key"
            InitializeComponent();
            
            
        }

        // Calculates length, width, area, & perimeter
        private void btnC_Click(object sender, EventArgs e)
        {
            decimal length = Convert.ToDecimal(txtL.Text);
            decimal width = Convert.ToDecimal(txtW.Text);
            decimal area = width * length;
            decimal perimeter = 2* width + 2 * length;

        //Pushes information to the text boxes
            txtL.Text = length.ToString();
            txtW.Text = width.ToString();
            txtA.Text = area.ToString();
            txtP.Text = perimeter.ToString();

            
        }

        // closes the program -or- use esc key
        private void btnE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
