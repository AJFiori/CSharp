using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace DailyCensusReport
{
    public partial class ViewRecordForm : Form
    {
        public ViewRecordForm()
        {
            InitializeComponent();
        }

        private void ViewRecordForm_Load(object sender, EventArgs e)
        {
            //These array items are for the combobox collection.
            string[] unitNames = {"Select A Unit Name...",
                "ICU", "T2", "PEDI", "T4",
                "6ACU", "TBC", "BHU"};

            foreach (string unitName in unitNames)
            {
                cbUnitName.Items.Add(unitName);
            }

            /*Setting the default value of the combobox to index 0 so it shows the first index of the array
              which is "Select A Unit Name..."*/
            cbUnitName.SelectedIndex = 0;

            //This takes the current day's date and adds 1 day to it. That way, the end date ("set date") goes on indefinitely.
            txtSetDate.Text = Convert.ToDateTime(DateTime.Today.AddDays(1)).ToShortDateString();
            txtSetDate.Visible = false;

            /*Pre-populates the search date field with today's date so the user can quickly check all the
              records for the current date :-)*/
            txtSearchDate.Text = Convert.ToDateTime(DateTime.Today).ToShortDateString();
            txtSearchDate.Select();
        }

        //Search by Date
        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
                //Converts the textbox data to DateTime so the database can recognize it.
                DateTime date1 = Convert.ToDateTime(txtSearchDate.Text);
                DateTime date2 = Convert.ToDateTime(txtSetDate.Text);

                //Populates information from the database into the Report Viewer
                this.HospitalDepartmentsTableAdapter.FillBy(this.SE265_AJF1130DataSet2.HospitalDepartments, date1, date2);

                //Checks to see if there are any records in the DB by the date, if not it pushes out the error
                if (SE265_AJF1130DataSet2.HospitalDepartments.Rows.Count == 0)
                {
                    DialogResult result = MessageBox.Show("No Records Found For That Date", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        DialogResult = DialogResult.None;
                        this.HospitalDepartmentsTableAdapter.ViewAllRecords(this.SE265_AJF1130DataSet2.HospitalDepartments);
                    }
                }

                this.rvViewRecords.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Incorrect Date Format \n\n" + "Please Try Using Date Formats Such As: \n" + "'MM/DD/YYYY' \n" + "'M/D/YYYY' \n" + "'M/DD/YY' \n" + "'MM/D/YYYY' \n" + "'MM/D/YY' \n", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Search by Unit Name
        private void cbUnitName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.HospitalDepartmentsTableAdapter.SearchByUnitName(this.SE265_AJF1130DataSet2.HospitalDepartments, cbUnitName.SelectedItem.ToString());

                this.rvViewRecords.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //view all records
        private void btnViewAllRecords_Click(object sender, EventArgs e)
        {
            try
            {
                this.HospitalDepartmentsTableAdapter.ViewAllRecords(this.SE265_AJF1130DataSet2.HospitalDepartments);

                this.rvViewRecords.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
