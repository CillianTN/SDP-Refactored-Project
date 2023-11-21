using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DogGroomSystem22
{
    public class appFunctions
    {
        private int appid;
        private String forename;
        private String surname;
        private int clientid;
        private String email;
        private String price;
        private String appdate;
        private String apptime;
        private String status;
        private String emailMsg;
        private String details;

        public appFunctions()
        {
            appid = 0;
            forename = "";
            surname = "";
            clientid = 0;
            email = "";
            price = "";
            appdate = "";
            apptime = "";
            status = "";
            details = "";

        }
        public appFunctions(int appid, String forename, String surname, int clientid, String email, String price, String appdate, String apptime, String status, String details)
        {
            this.appid = appid;
            this.forename = forename;
            this.surname = surname;
            this.clientid = clientid;
            this.email = email;
            this.price = price;
            this.appdate = appdate;
            this.apptime = apptime;
            this.status = status;
            this.details = details;
        }
        //getters

        public int getAppId()
        {
            return this.appid;
        }

        public int getClientId()
        {
            return this.clientid;
        }

        public String getForenameApp()
        {
            return this.forename;
        }

        public String getSurnameApp()
        {
            return this.surname;
        }

        public String getEmailApp()
        {
            return this.email;
        }

        public String getPriceApp()
        {
            return this.price;
        }

        public String getAppDate()
        {
            return this.appdate;
        }

        public String getAppTime()
        {
            return this.apptime;
        }

        public String getStatusApp()
        {
            return this.status;
        }

        public String getDetails()
        {
            return this.details;
        }


        public void setDetails(String details)
        {
            this.details = details;
        }
        public void setAppId(int appid)
        {
            this.appid = appid;
        }

        public void setClientId(int clientid)
        {
            this.clientid = clientid;
        }

        public void setForename(String forename)
        {
            this.forename = forename;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setPrice(String price)
        {
            this.price = price;
        }

        public void setAppDate(String appdate)
        {
            this.appdate = appdate;
        }

        public void setAppTime(String apptime)
        {
            this.apptime = apptime;
        }

        public void setStatusApp(String status)
        {
            this.status = status;
        }



        public static int getNextAppId()
        {
            int nextId = 1;

            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                string storedProcedure = "GetNextAppId";

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        nextId = Convert.ToInt32(result);
                    }
                }
            }

            return nextId;
        }

        public void addAppointment()
        {
            string storedProcedure = "InsertAppointment";

            // Connect
            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                // Execute and Query
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameters
                    cmd.Parameters.AddWithValue("@p_Forename", this.forename);
                    cmd.Parameters.AddWithValue("@p_Surname", this.surname);
                    cmd.Parameters.AddWithValue("@p_ClientId", this.clientid);
                    cmd.Parameters.AddWithValue("@p_Email", this.email);
                    cmd.Parameters.AddWithValue("@p_Price", this.price);

                    // Use ParseExact with the expected date format
                    cmd.Parameters.AddWithValue("@p_AppDate", DateTime.ParseExact(this.apptime, "dd-MM-yyyy", CultureInfo.InvariantCulture));

                    // Directly pass the apptime as it's stored as a string
                    cmd.Parameters.AddWithValue("@p_AppTime", this.appdate);

                    cmd.Parameters.AddWithValue("@p_Status", this.status);
                    cmd.Parameters.AddWithValue("@p_Details", this.details);

                    cmd.ExecuteNonQuery();
                }
            }
        }





        public static DataSet generateUpcomingApps()
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                string storedProcedure = "GenerateUpcomingApps";

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds, "AS");
                    }
                }
            }

            return ds;
        }

        public static DataSet generateAppointmentReminders()
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                string storedProcedure = "GenerateAppointmentReminders";

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds, "AS");
                    }
                }
            }

            return ds;
        }

        public void updateStatus()
        {
            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                // Stored Procedure
                string storedProcedure = "UpdateAppointmentStatus";

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter
                    cmd.Parameters.AddWithValue("@p_AppId", this.appid);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataSet getAppointments(string surname)
        {
            DataSet ds = new DataSet();

            //Connection
            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                // Stored Procedure
                string storedProcedure = "GetAppointmentsBySurname";

                //Command
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter
                    cmd.Parameters.AddWithValue("@p_Surname", surname);

                    da.Fill(ds, "AS");
                }
            }

            return ds;
        }


        public void getAppointment(int appId)
        {
            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                // Stored Procedure
                string storedProcedure = "GetAppointmentById";

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter
                    cmd.Parameters.AddWithValue("@p_AppId", appId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            this.appid = dr.GetInt32(0);
                            this.forename = dr.GetString(1);
                            this.surname = dr.GetString(2);
                            this.clientid = dr.GetInt32(3);
                            this.email = dr.GetString(4);
                            this.price = dr.GetDecimal(5).ToString();
                            this.appdate = dr.GetDateTime(6).ToString("dd-MM-yyyy");
                            this.apptime = dr.GetString(7);
                            this.status = dr.GetString(8);
                            this.details = dr.GetString(9);
                        }
                    }
                }
            }
        }


        public static DataSet getAppointments()
        {
            string storedProcedure = "GetAllAppointments";

            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    // Declare DataSet to return records to App
                    DataSet ds = new DataSet();
                    da.Fill(ds, "AS");
                    return ds;
                }
            }
        }


        public void getATime(string apptime)
        {
            // SQL Connection
            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                string storedProcedure = "GetAppointmentTime";

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter
                    cmd.Parameters.AddWithValue("@p_AppTime", apptime);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            this.apptime = dr.GetString(0);
                        }
                    }
                }
            }
        }

        public static DataSet getAppTime(string appdate)
        {
            string storedProcedure = "GetAvailableTimes";

            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AppDate", DateTime.Parse(appdate));

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "AT");
                        return ds;
                    }
                }
            }
        }


        public void removeAppointment(int appId)
        {
            string storedProcedure = "RemoveAppointment";

            using (SqlConnection conn = new SqlConnection(dbConnect.sqlConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AppId", appId);

                    cmd.ExecuteNonQuery();
                }
            }
        }



        public appFunctions(String email, String emailMsg)
        {
            this.email = email;
            this.emailMsg = emailMsg;
        }

        public void sendEmail()
        {
            /*using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;

                // Use App Password for Gmail
                var credentials = new NetworkCredential("cilliandgs@gmail.com", "dogGroomSystem2021");
                smtpClient.Credentials = credentials;

                smtpClient.Send("roisinmeehan21@gmail.com", this.email, "Appointment Info", this.emailMsg);
            }*/

            
        }

  

      }


}