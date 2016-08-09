using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace DailyCensusReport
{
    class CalculationColorChanger
    {

        public static bool CalcColor(
            //ICU
            TextBox txtCurrentCensusICU, TextBox txtCurrentCapStatusICU, TextBox txtAvailableBedsICU, TextBox txtIsoPatientsICU, TextBox txtDischargesICU,

            //T2
            TextBox txtCurrentCensusT2, TextBox txtCurrentCapStatusT2, TextBox txtAvailableBedsT2, TextBox txtIsoPatientsT2, TextBox txtDischargesT2,

            //PEDI
            TextBox txtCurrentCensusPEDI, TextBox txtCurrentCapStatusPEDI, TextBox txtAvailableBedsPEDI, TextBox txtIsoPatientsPEDI, TextBox txtDischargesPEDI,

            //T4
            TextBox txtCurrentCensusT4, TextBox txtCurrentCapStatusT4, TextBox txtAvailableBedsT4, TextBox txtIsoPatientsT4, TextBox txtDischargesT4,

            //6ACU
            TextBox txtCurrentCensus6ACU, TextBox txtCurrentCapStatus6ACU, TextBox txtAvailableBeds6ACU, TextBox txtIsoPatients6ACU, TextBox txtDischarges6ACU,

            //TBC
            TextBox txtCurrentCensusTBC, TextBox txtCurrentCapStatusTBC, TextBox txtAvailableBedsTBC, TextBox txtIsoPatientsTBC, TextBox txtDischargesTBC,

            //BHU
            TextBox txtCurrentCensusBHU, TextBox txtCurrentCapStatusBHU, TextBox txtAvailableBedsBHU, TextBox txtIsoPatientsBHU, TextBox txtDischargesBHU,

            //Total
            Label lblCCTotal, Label lblABTotal, Label lblISOTotal, Label lblTotalDC, TextBox txtCCSTotal)
        {

            #region ICU Calculation
            /*****ICU****/
            //Determine the ICU Current Capacity Status
            int totalICUBeds = 9;
            totalICUBeds = Convert.ToInt32(txtCurrentCensusICU.Text);
            //txtCurrentCapStatusICU.Text = "";

            if (totalICUBeds <= 2)
            {
                txtCurrentCapStatusICU.BackColor = Color.Green;
                txtCurrentCapStatusICU.Text = "GREEN";
            }
            else if (totalICUBeds <= 4)
            {
                txtCurrentCapStatusICU.BackColor = Color.Yellow;
                txtCurrentCapStatusICU.Text = "YELLOW";
            }
            else if (totalICUBeds <= 5)
            {
                txtCurrentCapStatusICU.BackColor = Color.Orange;
                txtCurrentCapStatusICU.Text = "ORANGE";
            }
            else if (totalICUBeds >= 6 && totalICUBeds <= 9)
            {
                txtCurrentCapStatusICU.BackColor = Color.Red;
                txtCurrentCapStatusICU.Text = "RED";
            }
            #endregion

            #region T2 Calculation
            /*****T2****/
            //Determine the T2 Current Capacity Status
            int totalT2Beds = 28;
            totalT2Beds = Convert.ToInt32(txtCurrentCensusT2.Text);
            //txtCurrentCapStatusT2.Text = "";

            if (totalT2Beds <= 14)
            {
                txtCurrentCapStatusT2.BackColor = Color.Green;
                txtCurrentCapStatusT2.Text = "GREEN";
            }
            else if (totalT2Beds <= 17)
            {
                txtCurrentCapStatusT2.BackColor = Color.Yellow;
                txtCurrentCapStatusT2.Text = "YELLOW";
            }
            else if (totalT2Beds <= 20)
            {
                txtCurrentCapStatusT2.BackColor = Color.Orange;
                txtCurrentCapStatusT2.Text = "ORANGE";
            }

            else if (totalT2Beds >= 20 && totalT2Beds <= 28)
            {
                txtCurrentCapStatusT2.BackColor = Color.Red;
                txtCurrentCapStatusT2.Text = "RED";
            }
            #endregion

            #region PEDI Calculation
            /*****PEDI****/
            //Determine the PEDI Current Capacity Status
            int totalPEDIBeds = 28;
            totalPEDIBeds = Convert.ToInt32(txtCurrentCensusPEDI.Text);
            //txtCurrentCapStatusPEDI.Text = "";

            if (totalPEDIBeds <= 14)
            {
                txtCurrentCapStatusPEDI.BackColor = Color.Green;
                txtCurrentCapStatusPEDI.Text = "GREEN";
            }
            else if (totalPEDIBeds <= 17)
            {
                txtCurrentCapStatusPEDI.BackColor = Color.Yellow;
                txtCurrentCapStatusPEDI.Text = "YELLOW";
            }
            else if (totalPEDIBeds <= 20)
            {
                txtCurrentCapStatusPEDI.BackColor = Color.Orange;
                txtCurrentCapStatusPEDI.Text = "ORANGE";
            }

            else if (totalPEDIBeds >= 20 && totalPEDIBeds <= 28)
            {
                txtCurrentCapStatusPEDI.BackColor = Color.Red;
                txtCurrentCapStatusPEDI.Text = "RED";
            }
            #endregion

            #region T4 Calculation
            /*****T4****/
            //Determine the T4 Current Capacity Status
            int totalT4Beds = 29;
            totalT4Beds = Convert.ToInt32(txtCurrentCensusT4.Text);
            //txtCurrentCapStatusT4.Text = "";

            if (totalT4Beds <= 14)
            {
                txtCurrentCapStatusT4.BackColor = Color.Green;
                txtCurrentCapStatusT4.Text = "GREEN";
            }
            else if (totalT4Beds <= 17)
            {
                txtCurrentCapStatusT4.BackColor = Color.Yellow;
                txtCurrentCapStatusT4.Text = "YELLOW";
            }
            else if (totalT4Beds <= 20)
            {
                txtCurrentCapStatusT4.BackColor = Color.Orange;
                txtCurrentCapStatusT4.Text = "ORANGE";
            }

            else if (totalT4Beds >= 20 && totalT4Beds <= 29)
            {
                txtCurrentCapStatusT4.BackColor = Color.Red;
                txtCurrentCapStatusT4.Text = "RED";
            }
            #endregion

            #region 6ACU Calculation

            /*****6ACU****/
            //Determine the 6ACU Current Capacity Status
            int total6ACUBeds = 10;
            total6ACUBeds = Convert.ToInt32(txtCurrentCensus6ACU.Text);

            if (total6ACUBeds <= 3)
            {
                txtCurrentCapStatus6ACU.BackColor = Color.Green;
                txtCurrentCapStatus6ACU.Text = "GREEN";
            }
            else if (total6ACUBeds <= 5)
            {
                txtCurrentCapStatus6ACU.BackColor = Color.Yellow;
                txtCurrentCapStatus6ACU.Text = "YELLOW";
            }
            else if (total6ACUBeds <= 6)
            {
                txtCurrentCapStatus6ACU.BackColor = Color.Orange;
                txtCurrentCapStatus6ACU.Text = "ORANGE";
            }
            else if (total6ACUBeds >= 7 && total6ACUBeds <= 10)
            {
                txtCurrentCapStatus6ACU.BackColor = Color.Red;
                txtCurrentCapStatus6ACU.Text = "RED";
            }

            #endregion

            #region TBC Calculation

            /*****TBC****/
            //Determine the TBC Current Capacity Status
            int totalTBCBeds = 10;
            totalTBCBeds = Convert.ToInt32(txtCurrentCensusTBC.Text);

            if (totalTBCBeds <= 3)
            {
                txtCurrentCapStatusTBC.BackColor = Color.Green;
                txtCurrentCapStatusTBC.Text = "GREEN";
            }
            else if (totalTBCBeds <= 5)
            {
                txtCurrentCapStatusTBC.BackColor = Color.Yellow;
                txtCurrentCapStatusTBC.Text = "YELLOW";
            }
            else if (totalTBCBeds <= 6)
            {
                txtCurrentCapStatusTBC.BackColor = Color.Orange;
                txtCurrentCapStatusTBC.Text = "ORANGE";
            }
            else if (totalTBCBeds >= 7 && totalTBCBeds <= 10)
            {
                txtCurrentCapStatusTBC.BackColor = Color.Red;
                txtCurrentCapStatusTBC.Text = "RED";
            }
            #endregion

            #region BHU Calculation

            /*****BHU****/
            //Determine the BHU Current Capacity Status
            int totalBHUBeds = 15;
            totalBHUBeds = Convert.ToInt32(txtCurrentCensusBHU.Text);

            if (totalBHUBeds <= 8)
            {
                txtCurrentCapStatusBHU.BackColor = Color.Green;
                txtCurrentCapStatusBHU.Text = "GREEN";
            }
            else if (totalBHUBeds <= 10)
            {
                txtCurrentCapStatusBHU.BackColor = Color.Yellow;
                txtCurrentCapStatusBHU.Text = "YELLOW";
            }
            else if (totalBHUBeds <= 11)
            {
                txtCurrentCapStatusBHU.BackColor = Color.Orange;
                txtCurrentCapStatusBHU.Text = "ORANGE";
            }
            else if (totalBHUBeds >= 12 && totalBHUBeds <= 15)
            {
                txtCurrentCapStatusBHU.BackColor = Color.Red;
                txtCurrentCapStatusBHU.Text = "RED";
            }
            #endregion

            #region Total Columns Calculation

            //Sum of Current Census Column
            int sumICUCensus = Convert.ToInt32(txtCurrentCensusICU.Text);
            int sumT2Census = Convert.ToInt32(txtCurrentCensusT2.Text);
            int sumPEDICensus = Convert.ToInt32(txtCurrentCensusPEDI.Text);
            int sumT4Census = Convert.ToInt32(txtCurrentCensusT4.Text);
            int sum6ACUCensus = Convert.ToInt32(txtCurrentCensus6ACU.Text);
            int sumTBCCensus = Convert.ToInt32(txtCurrentCensusTBC.Text);
            int sumBHUCensus = Convert.ToInt32(txtCurrentCensusBHU.Text);

            lblCCTotal.Text = Convert.ToInt32(sumICUCensus + sumT2Census + sumPEDICensus + sumT4Census + sum6ACUCensus + sumTBCCensus + sumBHUCensus).ToString();

            //Sum of AvailBeds Column
            int sumICUBeds = Convert.ToInt32(txtAvailableBedsICU.Text);
            int sumT2Beds = Convert.ToInt32(txtAvailableBedsT2.Text);
            int sumPEDIBeds = Convert.ToInt32(txtAvailableBedsPEDI.Text);
            int sumT4Beds = Convert.ToInt32(txtAvailableBedsT4.Text);
            int sum6ACUBeds = Convert.ToInt32(txtAvailableBeds6ACU.Text);
            int sumTBCBeds = Convert.ToInt32(txtAvailableBedsTBC.Text);
            int sumBHUBeds = Convert.ToInt32(txtAvailableBedsBHU.Text);

            lblABTotal.Text = Convert.ToInt32(sumICUBeds + sumT2Beds + sumPEDIBeds + sumT4Beds + sum6ACUBeds + sumTBCBeds + sumBHUBeds).ToString();

            //Sum of IsoPatients Column
            int sumICUIsoPatients = Convert.ToInt32(txtIsoPatientsICU.Text);
            int sumT2IsoPatients = Convert.ToInt32(txtIsoPatientsT2.Text);
            int sumPEDIIsoPatients = Convert.ToInt32(txtIsoPatientsPEDI.Text);
            int sumT4IsoPatients = Convert.ToInt32(txtIsoPatientsT4.Text);
            int sum6ACUIsoPatients = Convert.ToInt32(txtIsoPatients6ACU.Text);
            int sumTBCIsoPatients = Convert.ToInt32(txtIsoPatientsTBC.Text);
            int sumBHUIsoPatients = Convert.ToInt32(txtIsoPatientsBHU.Text);

            lblISOTotal.Text = Convert.ToInt32(sumICUIsoPatients + sumT2IsoPatients + sumPEDIIsoPatients + sumT4IsoPatients + sum6ACUIsoPatients + sumTBCIsoPatients + sumBHUIsoPatients).ToString();

            //Sum of Potenital DC's Column
            int sumICUDC = Convert.ToInt32(txtDischargesICU.Text);
            int sumT2DC = Convert.ToInt32(txtDischargesT2.Text);
            int sumPEDIDC = Convert.ToInt32(txtDischargesPEDI.Text);
            int sumT4DC = Convert.ToInt32(txtDischargesT4.Text);
            int sum6ACUDC = Convert.ToInt32(txtDischarges6ACU.Text);
            int sumTBCDC = Convert.ToInt32(txtDischargesTBC.Text);
            int sumBHUDC = Convert.ToInt32(txtDischargesBHU.Text);

            lblTotalDC.Text = Convert.ToInt32(sumICUDC + sumT2DC + sumPEDIDC + sumT4DC + sum6ACUDC + sumTBCDC + sumBHUDC).ToString();

            #region Total Hospital Census Status
            /*****Total Hospital Census Status****/

            //Determine the BHU Current Capacity Status
            int totalHospitalCensus = 129;
            totalHospitalCensus = Convert.ToInt32(lblCCTotal.Text);

            if (totalHospitalCensus <= 70)
            {
                txtCCSTotal.BackColor = Color.Green;
                txtCCSTotal.Text = "GREEN";
            }
            else if (totalHospitalCensus <= 80)
            {
                txtCCSTotal.BackColor = Color.Yellow;
                txtCCSTotal.Text = "YELLOW";
            }
            else if (totalHospitalCensus <= 90)
            {
                txtCCSTotal.BackColor = Color.Orange;
                txtCCSTotal.Text = "ORANGE";
            }
            else if (totalHospitalCensus >= 100 && totalHospitalCensus <= 129)
            {
                txtCCSTotal.BackColor = Color.Red;
                txtCCSTotal.Text = "RED";
            }
            #endregion
            /********************************************************************/
            #endregion

            return true;
        }
    }
}
