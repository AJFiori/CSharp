/* Hospital Daily Census Report *
 * Created By: Anthony Fiori III & Anthony Rondini *
 * Latest Update: 3/09/2016 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Outlook = Microsoft.Office.Interop.Outlook;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
//using System.Reflection;

namespace DailyCensusReport
{
    public partial class frmDailyCensusReport : Form
    {
        ViewRecordForm viewRecordForm = null;
        HelpForm helpForm = null;

        #region Unit TextBox Array
        public TextBox[] boxesICU { get; set; }
        public TextBox[] boxesT2 { get; set; }
        public TextBox[] boxesPEDI { get; set; }
        public TextBox[] boxesT4 { get; set; }
        public TextBox[] boxes6ACU { get; set; }
        public TextBox[] boxesTBC { get; set; }
        public TextBox[] boxesBHU { get; set; }
        #endregion

        public frmDailyCensusReport()
        {
            InitializeComponent();
        }

        private void frmDailyCensusReport_Load(object sender, EventArgs e)
        {
            lblHospDate.Text = DateTime.Today.ToLongDateString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Arrays for each unit to hold each variable
            #region Unit Array            
            string[] varICU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varT2 = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varPEDI = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varT4 = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] var6ACU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varTBC = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            string[] varBHU = new string[] { "currenCensus", "avalBeds", "numOfIsoPatients", "potentialDCs", "notes", "currentCapStat" };
            #endregion

            #region Checks Required Fields
            //Check to make sure all required fields are filled out
            if (txtIsoPatientsICU.Text == "" || txtDischargesICU.Text == "" || txtCurrentCensusICU.Text == "" ||
                txtIsoPatientsT2.Text == "" || txtDischargesT2.Text == "" || txtCurrentCensusT2.Text == "" ||
                txtIsoPatientsPEDI.Text == "" || txtDischargesPEDI.Text == "" || txtCurrentCensusPEDI.Text == "" ||
                txtIsoPatientsT4.Text == "" || txtDischargesT4.Text == "" || txtCurrentCensusT4.Text == "" ||
                txtIsoPatients6ACU.Text == "" || txtDischarges6ACU.Text == "" || txtCurrentCensus6ACU.Text == "" ||
                txtIsoPatientsTBC.Text == "" || txtDischargesTBC.Text == "" || txtCurrentCensusTBC.Text == "" ||
                txtIsoPatientsBHU.Text == "" || txtDischargesBHU.Text == "" || txtCurrentCensusBHU.Text == ""
                )
            {
                lblCurrentCensus.BackColor = Color.Red;
                lblIsolationPts.BackColor = Color.Red;
                lblPotentialDCs.BackColor = Color.Red;

                MessageBox.Show("Please Provide All Required Information", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            else
            {
                lblCurrentCensus.BackColor = Color.Transparent;
                lblIsolationPts.BackColor = Color.Transparent;
                lblPotentialDCs.BackColor = Color.Transparent;

                #region CalcColor Method Call
                /***Calling the CalcColor method from the CalculationColorChanger class***/
                CalculationColorChanger.CalcColor(
                  //ICU
                  txtCurrentCensusICU, txtCurrentCapStatusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU,

                  //T2
                  txtCurrentCensusT2, txtCurrentCapStatusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2,

                  //PEDI
                  txtCurrentCensusPEDI, txtCurrentCapStatusPEDI, txtAvailableBedsPEDI, txtIsoPatientsPEDI, txtDischargesPEDI,

                  //T4
                  txtCurrentCensusT4, txtCurrentCapStatusT4, txtAvailableBedsT4, txtIsoPatientsT4, txtDischargesT4,

                  //6ACU
                  txtCurrentCensus6ACU, txtCurrentCapStatus6ACU, txtAvailableBeds6ACU, txtIsoPatients6ACU, txtDischarges6ACU,

                  //TBC
                  txtCurrentCensusTBC, txtCurrentCapStatusTBC, txtAvailableBedsTBC, txtIsoPatientsTBC, txtDischargesTBC,

                  //BHU
                  txtCurrentCensusBHU, txtCurrentCapStatusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU,

                  ////Total
                  lblCCTotal, lblABTotal, lblISOTotal, lblTotalDC, txtCCSTotal
                  );
                #endregion
                /*A series of for-loops for each unit that iterates through their unique textboxes
                and gives them a static unitID of 1-7. We did this because we didn't want to decalre
                a bunch of different variables and whatnot. The for-loops and arrays seemed like a 
                better idea.*/
                #region For Loops for TextBoxes
                /***********************************************************************************************************************************************************************/
                //ICU
                int unitID = 1;
                boxesICU = new TextBox[] { txtCurrentCensusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU };
                for (int i = 0; i < boxesICU.Length; i++)
                {
                    varICU[i] = Convert.ToString(boxesICU[i].Text);
                }

                //T2
                int unitIDT2 = 2;
                boxesT2 = new TextBox[] { txtCurrentCensusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2, txtNotesT2, txtCurrentCapStatusT2 };
                for (int i = 0; i < boxesT2.Length; i++)
                {
                    varT2[i] = Convert.ToString(boxesT2[i].Text);
                }

                //PEDI
                int unitIDPEDI = 3;
                boxesPEDI = new TextBox[] { txtCurrentCensusPEDI, txtAvailableBedsPEDI, txtIsoPatientsPEDI, txtDischargesPEDI, txtNotesPEDI, txtCurrentCapStatusPEDI };
                for (int i = 0; i < boxesPEDI.Length; i++)
                {
                    varPEDI[i] = Convert.ToString(boxesPEDI[i].Text);
                }

                //T4
                int unitIDT4 = 4;
                boxesPEDI = new TextBox[] { txtCurrentCensusT4, txtAvailableBedsT4, txtIsoPatientsT4, txtDischargesT4, txtNotesT4, txtCurrentCapStatusT4 };
                for (int i = 0; i < boxesPEDI.Length; i++)
                {
                    varT4[i] = Convert.ToString(boxesPEDI[i].Text);
                }

                //6ACU
                int unitID6ACU = 5;
                boxes6ACU = new TextBox[] { txtCurrentCensus6ACU, txtAvailableBeds6ACU, txtIsoPatients6ACU, txtDischarges6ACU, txtNotes6ACU, txtCurrentCapStatus6ACU };
                for (int i = 0; i < boxes6ACU.Length; i++)
                {
                    var6ACU[i] = Convert.ToString(boxes6ACU[i].Text);
                }

                //TBC
                int unitIDTBC = 6;
                boxesTBC = new TextBox[] { txtCurrentCensusTBC, txtAvailableBedsTBC, txtIsoPatientsTBC, txtDischargesTBC, txtNotesTBC, txtCurrentCapStatusTBC };
                for (int i = 0; i < boxesTBC.Length; i++)
                {
                    varTBC[i] = Convert.ToString(boxesTBC[i].Text);
                }

                //BHU
                int unitIDBHU = 7;
                boxesBHU = new TextBox[] { txtCurrentCensusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU, txtNotesBHU, txtCurrentCapStatusBHU };
                for (int i = 0; i < boxesBHU.Length; i++)
                {
                    varBHU[i] = Convert.ToString(boxesBHU[i].Text);
                }
                /***********************************************************************************************************************************************************************/
                #endregion

                //Confirmation for user if they want to save or cancel
                DialogResult result = MessageBox.Show("This Record Contains Unsaved Data." + "\n\n" + "Do You Want To Save It?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                /*If the user selects 'Yes', it will raise the PDF Save Box, and when they save
                and when they click 'OK' on the Save Confirmation for the PDF, it then gets submitted
                into the database.*/
                if (result == DialogResult.Yes)
                {

                    //Calling the PDFView method from the PDFSubmit class.
                    #region PDF Method Call
                    PDFSubmit.PDFView(
                      //ICU
                      txtCurrentCensusICU, txtAvailableBedsICU, txtIsoPatientsICU, txtDischargesICU, txtNotesICU, txtCurrentCapStatusICU,

                      //T2
                      txtCurrentCensusT2, txtAvailableBedsT2, txtIsoPatientsT2, txtDischargesT2, txtNotesT2, txtCurrentCapStatusT2,

                      //PEDI
                      txtCurrentCensusPEDI, txtAvailableBedsPEDI, txtIsoPatientsPEDI, txtDischargesPEDI, txtNotesPEDI, txtCurrentCapStatusPEDI,

                      //T4
                      txtCurrentCensusT4, txtAvailableBedsT4, txtIsoPatientsT4, txtDischargesT4, txtNotesT4, txtCurrentCapStatusT4,

                      //6ACU
                      txtCurrentCensus6ACU, txtAvailableBeds6ACU, txtIsoPatients6ACU, txtDischarges6ACU, txtNotes6ACU, txtCurrentCapStatus6ACU,

                      //TBC
                      txtCurrentCensusTBC, txtAvailableBedsTBC, txtIsoPatientsTBC, txtDischargesTBC, txtNotesTBC, txtCurrentCapStatusTBC,

                      //BHU
                      txtCurrentCensusBHU, txtAvailableBedsBHU, txtIsoPatientsBHU, txtDischargesBHU, txtNotesBHU, txtCurrentCapStatusBHU,

                      //Total
                      lblCCTotal, lblABTotal, lblISOTotal, lblTotalDC, lbltotalNotes, txtCCSTotal
                      );
                    #endregion

                    /*Calling the Insert methods from the SubmitRecord class.
                    Takes in the unitIDs for each unit and an array of variables.*/
                    #region SubmitRecord Method Call                   
                    SubmitRecord.InsertICU(unitID, varICU);
                    SubmitRecord.InsertT2(unitIDT2, varT2);
                    SubmitRecord.InsertPEDI(unitIDPEDI, varPEDI);
                    SubmitRecord.InsertT4(unitIDT4, varT4);
                    SubmitRecord.Insert6ACU(unitID6ACU, var6ACU);
                    SubmitRecord.InsertTBC(unitIDTBC, varTBC);
                    SubmitRecord.InsertBHU(unitIDBHU, varBHU);

                    #endregion

                }
                else if (result == DialogResult.No)
                {
                    DialogResult = DialogResult.None;
                }

            }
        }

        //Brings You To The View Record Form
        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            //Opens form and Checks if the same form is open
            if (viewRecordForm == null || viewRecordForm.Text == "")
            {
                viewRecordForm = new ViewRecordForm();

                viewRecordForm.Dock = DockStyle.Fill;
                viewRecordForm.Show();
            }
            else if (CheckOpened(viewRecordForm.Text))
            {
                //If window is open, it will pull up that same window
                viewRecordForm.WindowState = FormWindowState.Normal;
                viewRecordForm.Dock = DockStyle.Fill;
                viewRecordForm.Show();
                viewRecordForm.Focus();
            }
        }

        //Brings You To The Help Form
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Opens form and Checks if the same form is open
            if (helpForm == null || helpForm.Text == "")
            {
                helpForm = new HelpForm();

                helpForm.Dock = DockStyle.Fill;
                helpForm.Show();
            }
            else if (CheckOpened(helpForm.Text))
            {
                //If window is already open, and the button is clicked again, the window will be brought back up.
                helpForm.WindowState = FormWindowState.Normal;
                helpForm.Dock = DockStyle.Fill;
                helpForm.Show();
                helpForm.Focus();
            }
        }

        /*These TextChanged events calculate the available beds, check for null
        or whitespace, and check to see if strings are entered or not. Each check
        sends out an appropriate error message. We decided to do text changed events
        instead of on the submit click because we felt it was a bit more convienant for
        the ones filling out the information. So they can know they put in something wrong
        right then and there.*/

        #region TextChanged Events
        /*****************************************************************************/
        private void txtCurrentCensusICU_TextChanged(object sender, EventArgs e)
        {
            #region Checks Current Census ICU Field           
            int icuCensus = 0;
            Int32.TryParse(txtCurrentCensusICU.Text, out icuCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusICU.Text))
                {
                    int icuNumCheck;
                    if (!int.TryParse(txtCurrentCensusICU.Text, out icuNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        txtCurrentCensusICU.Text = "";
                    }
                    else {
                        if (Convert.ToInt32(txtCurrentCensusICU.Text) > 9)
                        {
                            MessageBox.Show("ICU Current Census cannot exceed 9 patients", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAvailableBedsICU.Text = "";
                            txtCurrentCensusICU.Text = "";
                        }

                        if (icuCensus <= 9)
                        {
                            txtAvailableBedsICU.Text = Convert.ToInt32(9 - icuCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusICU.Text))
                {
                    txtAvailableBedsICU.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion

        }

        private void txtIsoPatientsICU_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient ICU Field

            int icuIsoCensus = 0;
            Int32.TryParse(txtIsoPatientsICU.Text, out icuIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsICU.Text))
                {
                    int icuIsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsICU.Text, out icuIsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIsoPatientsICU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtDischargesICU_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC ICU Field

            int icuDCCensus = 0;
            Int32.TryParse(txtDischargesICU.Text, out icuDCCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesICU.Text))
                {
                    int icuDCNumCheck;
                    if (!int.TryParse(txtDischargesICU.Text, out icuDCNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDischargesICU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtCurrentCensusT2_TextChanged(object sender, EventArgs e)
        {
            #region Checks T2 Current Census Field
            try
            {
                // Checks to see if it is over 28 patients, if it's over it will clear textbox fields
                int t2Census = 0;
                Int32.TryParse(txtCurrentCensusT2.Text, out t2Census);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusT2.Text))
                {
                    int t2NumCheck;
                    if (!int.TryParse(txtCurrentCensusT2.Text, out t2NumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentCensusT2.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusT2.Text) > 28)
                        {
                            MessageBox.Show("T2 Current Census cannot exceed 28 patients", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAvailableBedsT2.Text = "";
                            txtCurrentCensusT2.Text = "";
                        }

                        if (t2Census <= 28)
                        {
                            txtAvailableBedsT2.Text = Convert.ToInt32(28 - t2Census).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusT2.Text))
                {

                    txtAvailableBedsT2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtIsoPatientsT2_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient T2 Field

            int t2IsoCensus = 0;
            Int32.TryParse(txtIsoPatientsT2.Text, out t2IsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsT2.Text))
                {
                    int t2IsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsT2.Text, out t2IsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIsoPatientsT2.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtDischargesT2_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC T2 Field

            int t2IsoCensus = 0;
            Int32.TryParse(txtDischargesT2.Text, out t2IsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesT2.Text))
                {
                    int t2DcNumCheck;
                    if (!int.TryParse(txtDischargesT2.Text, out t2DcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDischargesT2.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtCurrentCensusPEDI_TextChanged(object sender, EventArgs e)
        {
            #region Checks PEDI Current Census Field
            try
            {
                // Checks to see if it is over 28 patients, if it's over it will clear textbox fields
                int pediCensus = 0;
                Int32.TryParse(txtCurrentCensusPEDI.Text, out pediCensus);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusPEDI.Text))
                {
                    int pediNumCheck;
                    if (!int.TryParse(txtCurrentCensusPEDI.Text, out pediNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentCensusPEDI.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusPEDI.Text) > 28)
                        {
                            MessageBox.Show("PEDI Current Census cannot exceed 28 patients", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAvailableBedsPEDI.Text = "";
                            txtCurrentCensusPEDI.Text = "";
                        }

                        if (pediCensus <= 28)
                        {
                            txtAvailableBedsPEDI.Text = Convert.ToInt32(28 - pediCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusPEDI.Text))
                {

                    txtAvailableBedsPEDI.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtIsoPatientsPEDI_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient PEDI Field

            int pediIsoCensus = 0;
            Int32.TryParse(txtIsoPatientsPEDI.Text, out pediIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsPEDI.Text))
                {
                    int pediDcNumCheck;
                    if (!int.TryParse(txtIsoPatientsPEDI.Text, out pediDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIsoPatientsPEDI.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtDischargesPEDI_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC PEDI Field

            int pediDcCensus = 0;
            Int32.TryParse(txtDischargesPEDI.Text, out pediDcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesPEDI.Text))
                {
                    int pediDcNumCheck;
                    if (!int.TryParse(txtDischargesPEDI.Text, out pediDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDischargesPEDI.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtCurrentCensusT4_TextChanged(object sender, EventArgs e)
        {
            #region Checks T4 Current Census Field
            try
            {
                // Checks to see if it is over 29 patients, if it's over it will clear textbox fields
                int t4Census = 0;
                Int32.TryParse(txtCurrentCensusT4.Text, out t4Census);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusT4.Text))
                {
                    int t4NumCheck;
                    if (!int.TryParse(txtCurrentCensusT4.Text, out t4NumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentCensusT4.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusT4.Text) > 29)
                        {
                            MessageBox.Show("T4 Current Census cannot exceed 29 patients", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAvailableBedsT4.Text = "";
                            txtCurrentCensusT4.Text = "";
                        }

                        if (t4Census <= 29)
                        {
                            txtAvailableBedsT4.Text = Convert.ToInt32(29 - t4Census).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusT4.Text))
                {

                    txtAvailableBedsT4.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtIsoPatientsT4_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient T4 Field

            int t4IsoCensus = 0;
            Int32.TryParse(txtIsoPatientsT4.Text, out t4IsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsT4.Text))
                {
                    int t4IsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsT4.Text, out t4IsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIsoPatientsT4.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtDischargesT4_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC T4 Field

            int t4DcCensus = 0;
            Int32.TryParse(txtDischargesT4.Text, out t4DcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesT4.Text))
                {
                    int t4DcNumCheck;
                    if (!int.TryParse(txtDischargesT4.Text, out t4DcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDischargesT4.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtCurrentCensus6ACU_TextChanged(object sender, EventArgs e)
        {
            #region Checks 6ACU Current Census Field
            try
            {
                // Checks to see if it is over 10 patients, if it's over it will clear textbox fields
                int acuCensus = 0;
                Int32.TryParse(txtCurrentCensus6ACU.Text, out acuCensus);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensus6ACU.Text))
                {
                    int acuNumCheck;
                    if (!int.TryParse(txtCurrentCensus6ACU.Text, out acuNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentCensus6ACU.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensus6ACU.Text) > 10)
                        {
                            MessageBox.Show("6ACU Current Census cannot exceed 10 patients", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAvailableBeds6ACU.Text = "";
                            txtCurrentCensus6ACU.Text = "";
                        }

                        if (acuCensus <= 10)
                        {
                            txtAvailableBeds6ACU.Text = Convert.ToInt32(10 - acuCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensus6ACU.Text))
                {

                    txtAvailableBeds6ACU.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtIsoPatients6ACU_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient 6ACU Field

            int acuIsoCensus = 0;
            Int32.TryParse(txtIsoPatients6ACU.Text, out acuIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatients6ACU.Text))
                {
                    int acuIsoNumCheck;
                    if (!int.TryParse(txtIsoPatients6ACU.Text, out acuIsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIsoPatients6ACU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtDischarges6ACU_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC 6ACU Field

            int acuDcCensus = 0;
            Int32.TryParse(txtDischarges6ACU.Text, out acuDcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischarges6ACU.Text))
                {
                    int acuDcNumCheck;
                    if (!int.TryParse(txtDischarges6ACU.Text, out acuDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDischarges6ACU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtCurrentCensusTBC_TextChanged(object sender, EventArgs e)
        {
            #region Checks TBC Current Census Field
            try
            {
                // Checks to see if it is over 10 patients, if it's over it will clear textbox fields
                int tbcCensus = 0;
                Int32.TryParse(txtCurrentCensusTBC.Text, out tbcCensus);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusTBC.Text))
                {
                    int tbcNumCheck;
                    if (!int.TryParse(txtCurrentCensusTBC.Text, out tbcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentCensusTBC.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusTBC.Text) > 10)
                        {
                            MessageBox.Show("TBC Current Census cannot exceed 10 patients", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAvailableBedsTBC.Text = "";
                            txtCurrentCensusTBC.Text = "";
                        }

                        if (tbcCensus <= 10)
                        {
                            txtAvailableBedsTBC.Text = Convert.ToInt32(10 - tbcCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusTBC.Text))
                {

                    txtAvailableBedsTBC.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtIsoPatientsTBC_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient TBC Field

            int tbcIsoCensus = 0;
            Int32.TryParse(txtIsoPatientsTBC.Text, out tbcIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsTBC.Text))
                {
                    int tbcIsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsTBC.Text, out tbcIsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIsoPatientsTBC.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtDischargesTBC_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC TBC Field

            int tbcDcCensus = 0;
            Int32.TryParse(txtDischargesTBC.Text, out tbcDcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesTBC.Text))
                {
                    int tbcDcNumCheck;
                    if (!int.TryParse(txtDischargesTBC.Text, out tbcDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDischargesTBC.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtCurrentCensusBHU_TextChanged(object sender, EventArgs e)
        {
            #region Checks BHU Current Census Field
            try
            {
                // Checks to see if it is over 15 patients, if it's over it will clear textbox fields
                int bhuCensus = 0;
                Int32.TryParse(txtCurrentCensusBHU.Text, out bhuCensus);
                if (!string.IsNullOrWhiteSpace(txtCurrentCensusBHU.Text))
                {
                    int bhuNumCheck;
                    if (!int.TryParse(txtCurrentCensusBHU.Text, out bhuNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentCensusBHU.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtCurrentCensusBHU.Text) > 15)
                        {
                            MessageBox.Show("BHU Current Census cannot exceed 15 patients", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAvailableBedsBHU.Text = "";
                            txtCurrentCensusBHU.Text = "";
                        }

                        if (bhuCensus <= 15)
                        {
                            txtAvailableBedsBHU.Text = Convert.ToInt32(15 - bhuCensus).ToString();
                        }
                    }
                }
                if (string.IsNullOrWhiteSpace(txtCurrentCensusBHU.Text))
                {
                    if (bhuCensus <= 15)
                    {
                        txtAvailableBedsBHU.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtIsoPatientsBHU_TextChanged(object sender, EventArgs e)
        {
            #region Checks ISO Patient BHU Field

            int bhuIsoCensus = 0;
            Int32.TryParse(txtIsoPatientsBHU.Text, out bhuIsoCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtIsoPatientsBHU.Text))
                {
                    int bhuIsoNumCheck;
                    if (!int.TryParse(txtIsoPatientsBHU.Text, out bhuIsoNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIsoPatientsBHU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }

        private void txtDischargesBHU_TextChanged(object sender, EventArgs e)
        {
            #region Checks DC BHU Field

            int bhuDcCensus = 0;
            Int32.TryParse(txtDischargesBHU.Text, out bhuDcCensus);

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDischargesBHU.Text))
                {
                    int bhuDcNumCheck;
                    if (!int.TryParse(txtDischargesBHU.Text, out bhuDcNumCheck))
                    {
                        MessageBox.Show("Please Enter A Number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDischargesBHU.Text = "";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            #endregion
        }
        /**************************************************************************/
        #endregion

        //Method to check if a form is already open or not.
        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        //Closes Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            /*Saves the user from putting in information and accidentally hitting the Exit button.
              Brings up a Confirm. message asking if they want to exit only if there's data present in the text fields.*/
            #region Exit Confirm            
            if (txtIsoPatientsICU.Text != "" || txtDischargesICU.Text != "" || txtCurrentCensusICU.Text != "" ||
                txtIsoPatientsT2.Text != "" || txtDischargesT2.Text != "" || txtCurrentCensusT2.Text != "" ||
                txtIsoPatientsPEDI.Text != "" || txtDischargesPEDI.Text != "" || txtCurrentCensusPEDI.Text != "" ||
                txtIsoPatientsT4.Text != "" || txtDischargesT4.Text != "" || txtCurrentCensusT4.Text != "" ||
                txtIsoPatients6ACU.Text != "" || txtDischarges6ACU.Text != "" || txtCurrentCensus6ACU.Text != "" ||
                txtIsoPatientsTBC.Text != "" || txtDischargesTBC.Text != "" || txtCurrentCensusTBC.Text != "" ||
                txtIsoPatientsBHU.Text != "" || txtDischargesBHU.Text != "" || txtCurrentCensusBHU.Text != ""
                )
            {
                DialogResult exitCheck = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (exitCheck == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (exitCheck == DialogResult.No)
                {
                    exitCheck = DialogResult.None;
                }
                
            }
                else
                {
                    this.Close();
                }
            #endregion
        }
    }
}

