using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    internal class PatientDBHelper
    {

        // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=Fals
        static string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hmsdb;Integrated Security=True";
        //"Data Source=10.1.7.102;Initial Catalog=hmsdb;User ID=aptuser;Password=apt2023";

        public PatientDBHelper() {
        }

        public static List<Patient> GetPatients()
        { 
          List<Patient> list = new List<Patient>();
        
           SqlConnection  conn = new SqlConnection();
           conn.ConnectionString = connString;
           conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                sqlCommand.CommandText = "Select * from Patient";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Patient p = new Patient();
                    p.PID = sqlDataReader.GetInt64(0);
                    p.Name = sqlDataReader.GetString(1);
                    p.DoB = sqlDataReader.GetDateTime(2);
                    p.Gender = (Gender) sqlDataReader.GetInt16(3);
                    p.Email = sqlDataReader.GetString(4);

                    list.Add(p);
                }
                
                conn.Close();
            }
            else
            {

                MessageBox.Show("Error in Connection....");
            }
          return list;
        }

        internal static long GetNextID()
        {
            long maxid = 0;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                sqlCommand.CommandText = "Select Max(PID) from Patient";

                maxid = (long) sqlCommand.ExecuteScalar();                        

                conn.Close();
            }

            return maxid + 1;
        }

        internal static void InsertPatient(Patient currPatient)
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand sqlCommand = conn.CreateCommand();

                /* sqlCommand.CommandText = "Insert into Patient Values("+
                     currPatient.PID + ",'" +
                     currPatient.Name + "','" +
                     currPatient.DoB.ToString("yyyy-MM-dd") + "'," +
                     (int)currPatient.Gender + ",'" +
                     currPatient.Email + "')";*/

                sqlCommand.CommandText = "Insert into Patient Values(@PID,@NAME,@DOB,@GENDER,@EMAIL)";
                sqlCommand.Parameters.AddWithValue("@PID", currPatient.PID);
                sqlCommand.Parameters.AddWithValue("@NAME", currPatient.Name);
                sqlCommand.Parameters.AddWithValue("@DOB", currPatient.DoB);
                sqlCommand.Parameters.AddWithValue("@GENDER", currPatient.Gender);
                sqlCommand.Parameters.AddWithValue("@EMAIL", currPatient.Email);



                sqlCommand.ExecuteNonQuery();
             

                conn.Close();
            }


        }

        internal static void UpdatePatient(Patient currPatient)
        {
            //
        }
    }
}
