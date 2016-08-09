using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DailyCensusReport
{
    public class SubmitRecord
    {
        //ICU Insert Method
        public static void InsertICU(int unitID, string[] varICU)
        {
            //Creating the database connection.
            SqlConnection connect = DBConnect.GetConnection();

            SqlCommand cmd = new SqlCommand("spInsertICU", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertICU";

            /*Adding parameters to their respective values/variables. In this case, their values are
            in an array of variables that are equal to the user's input.*/
            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitID;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varICU[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varICU[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varICU[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varICU[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varICU[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varICU[5];

            try
            {
                connect.Open();
                //Executes then check to see if correct.
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
            }
        }

        /*
         Everything in the methods below are 
         practically the same as the ICU Insert 
         method
         */

        public static void InsertT2(int unitIDT2, string[] varT2)
        {
            //Connects to T2 Stored procedure to insert
            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertT2", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertT2";

            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitIDT2;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varT2[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varT2[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varT2[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varT2[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varT2[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varT2[5];

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
            }
        }

        public static void InsertPEDI(int unitIDPEDI, string[] varPEDI)
        {
            //Connects to PEDI Stored procedure to insert
            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertPEDI", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertPEDI";

            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitIDPEDI;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varPEDI[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varPEDI[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varPEDI[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varPEDI[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varPEDI[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varPEDI[5];

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
            }
        }

        public static void InsertT4(int unitIDT4, string[] varT4)
        {
            //Connects to T4 Stored procedure to insert
            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertT4", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertT4";

            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitIDT4;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varT4[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varT4[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varT4[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varT4[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varT4[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varT4[5];

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
            }
        }

        public static void Insert6ACU(int unitID6ACU, string[] var6ACU)
        {
            //Connects to 6ACU Stored procedure to insert
            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsert6ACU", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsert6ACU";

            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitID6ACU;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = var6ACU[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = var6ACU[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = var6ACU[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = var6ACU[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = var6ACU[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = var6ACU[5];

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
            }
        }

        public static void InsertTBC(int unitIDTBC, string[] varTBC)
        {
            //Connects to TBC Stored procedure to insert
            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertTBC", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertTBC";

            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitIDTBC;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varTBC[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varTBC[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varTBC[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varTBC[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varTBC[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varTBC[5];

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
            }
        }

        public static void InsertBHU(int unitIDBHU, string[] varBHU)
        {
            //Connects to BHU Stored procedure to insert
            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertBHU", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertBHU";

            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitIDBHU;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varBHU[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varBHU[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varBHU[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varBHU[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varBHU[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varBHU[5];

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
            }
        }
    }
}
