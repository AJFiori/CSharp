using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// remark
namespace Fiori_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // decliar varibles
        string StudentsName, Class;
        decimal Grade;


        //Provides grade
        private void btnGrade_Click_1(object sender, EventArgs e)
        {
            string StudentsName = txtSN.Text;
            string Class = txtCL.Text;
            string LGrade = "";
            decimal Grade = Convert.ToDecimal(txtGR.Text);
            
            Grade = 0;
            txtSN.Text = "";
            txtCL.Text = "";
            txtGR.Text = "";
            txtOutPut.Text = "";
            lblER.Text = "Please Enter information";
            
            if (Grade > 100)
            {
                lblER.Text = "**Please enter a valid grade**";
            }

            else if (Grade >= 94 && Grade <= 100)
            {
                LGrade = "A";
            }

            else if (Grade >= 90 && Grade < 93)
            {
                LGrade = "A-";
            }

            else if (Grade >= 87 && Grade < 89)
            {
                LGrade = "B+";
            }

            else if (Grade >= 84 && Grade < 86)
            {
                LGrade = "B";
            }

            else if (Grade >= 80 && Grade < 83)
            {
                LGrade = "B-";

            }

            else if (Grade >= 77 && Grade < 79)
            {
                LGrade = "C+";

            }

            else if (Grade >= 74 && Grade < 76)
            {
                LGrade = "C";

            }

            else if (Grade >= 70 && Grade < 73)
            {
                LGrade = "C-";

            }

            else if (Grade >= 65 && Grade < 69)
            {
                LGrade = "D";

            }

            else if (Grade < 65)
            {
                LGrade = "F";

            }

            
            switch (Class)
            {
                
                case "M":
                case "m":
                    if (Grade > 100)
                    {
                        lblER.Text = "**Please enter a valid grade**";
                    }
                        else if (Grade <=100){
                        txtOutPut.Text = StudentsName + " " + "Look at that, you got a " + LGrade + " in Math";
                    }
                    break;

                case "S":
                case "s":
                    if (Grade > 100)
                    {
                        lblER.Text = "**Please enter a valid grade**";
                    }
                    else if (Grade <= 100)
                    {
                        txtOutPut.Text = StudentsName + " " + "Look at that, you got a " + LGrade + " in Science";
                    }
                    break;

                case "E":
                case "e":
                    if(Grade > 100)
                    {
                        lblER.Text = "**Please enter a valid grade**";
                    }
                    else if (Grade <= 100)
                    {
                        txtOutPut.Text = StudentsName + " " + "Look at that, you got a " + LGrade + " in English";
                    }
                    break;
                    
                default:
                   txtOutPut.Text = "Invalid Class type! Enter M for Math, S for Science or E for English only";
                    break;
            }
        }


        // clear program fields
        private void BtnC_Click_1(object sender, EventArgs e)
        {
            Grade = 0;
            txtSN.Text = "";
            txtCL.Text = "";
            txtGR.Text = "";
            txtOutPut.Text = "";
            lblER.Text = "";
        }

        
        //Exit program
        private void btnE_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
