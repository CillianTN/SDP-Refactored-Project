using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DogGroomSystem22
{
    public class clientFunctions
    {
        private int clientId;
        private String forename;
        private String surname;
        private String city;
        private String town;
        private String street;
        private String email;
        private String phone;

        // Constructors
        public clientFunctions()
        {
            clientId = 0;
            forename = "";
            surname = "";
            city = "";
            street = "";
            town = "";
            email = "";
            phone = "";
        }

        public clientFunctions(int clientId, String forename, String surname, String city, String town, String street, String email, String phone)
        {
            this.clientId = clientId;
            this.forename = forename;
            this.surname = surname;
            this.city = city;
            this.town = town;
            this.street = street;
            this.email = email;
            this.phone = phone;
        }

        // Getters and Setters
        public int getId()
        {
            return this.clientId;
        }

        public String getForename()
        {
            return this.forename;
        }

        public String getSurname()
        {
            return this.surname;
        }

        public String getCity()
        {
            return this.city;
        }

        public String getTown()
        {
            return this.town;
        }

        public String getStreet()
        {
            return this.street;
        }

        public String getEmail()
        {
            return this.email;
        }

        public String getPhone()
        {
            return this.phone;
        }

        public void setId(int clientid)
        {
            this.clientId = clientid;
        }

        public void setForename(String forename)
        {
            this.forename = forename;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setCity(String city)
        {
            this.city = city;
        }

        public void setTown(String town)
        {
            this.town = town;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        // Other methods

        public static int getNextClientId()
        {
            int nextId = 1;

            try
            {
                using (SqlConnection conn = dbConnect.Instance.getSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetNextClientID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            nextId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return nextId;
        }

        public static DataSet getClients()
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection conn = dbConnect.Instance.getSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("ClientByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(ds, "WS");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return ds;
        }

        public void addClient()
        {
            try
            {
                using (SqlConnection conn = dbConnect.Instance.getSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertClient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parameters
                        cmd.Parameters.AddWithValue("@p_Forename", this.forename);
                        cmd.Parameters.AddWithValue("@p_Surname", this.surname);
                        cmd.Parameters.AddWithValue("@p_City", this.city);
                        cmd.Parameters.AddWithValue("@p_Town", this.town);
                        cmd.Parameters.AddWithValue("@p_Street", this.street);
                        cmd.Parameters.AddWithValue("@p_Email", this.email);
                        cmd.Parameters.AddWithValue("@p_Phone", this.phone);
                        cmd.Parameters.AddWithValue("@p_Status", "A");

                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Client added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static DataSet getClients(string surname)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = dbConnect.Instance.getSqlConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetClientsBySurname", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter
                    cmd.Parameters.AddWithValue("@p_Surname", surname);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds, "CS");
                    }
                }
            }

            return ds;
        }

        public void updateClient()
        {
            try
            {
                using (SqlConnection conn = dbConnect.Instance.getSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("UpdateClient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parameters
                        cmd.Parameters.AddWithValue("@p_ClientID", this.clientId);
                        cmd.Parameters.AddWithValue("@p_Forename", this.forename);
                        cmd.Parameters.AddWithValue("@p_Surname", this.surname);
                        cmd.Parameters.AddWithValue("@p_City", this.city);
                        cmd.Parameters.AddWithValue("@p_Town", this.town);
                        cmd.Parameters.AddWithValue("@p_Street", this.street);
                        cmd.Parameters.AddWithValue("@p_Email", this.email);
                        cmd.Parameters.AddWithValue("@p_Phone", this.phone);

                        // Execute the update
                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Update successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void getClient(int CID)
        {
            try
            {
                using (SqlConnection conn = dbConnect.Instance.getSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetClient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parameter
                        cmd.Parameters.AddWithValue("@p_ClientID", CID);

                        // Execute the query
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                this.clientId = dr.GetInt32(0);
                                this.forename = dr.GetString(1);
                                this.surname = dr.GetString(2);
                                this.city = dr.GetString(3);
                                this.town = dr.GetString(4);
                                this.street = dr.GetString(5);
                                this.email = dr.GetString(6);
                                this.phone = dr.GetString(7);
                            }
                            else
                            {
                                // Handle the case where no matching client is found
                                Console.WriteLine("Client not found.");
                            }
                        }
                    }
                }

                Console.WriteLine("Client retrieval successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void removeClient(int clientId)
        {
            try
            {
                using (SqlConnection conn = dbConnect.Instance.getSqlConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("RemoveClient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parameter
                        cmd.Parameters.AddWithValue("@p_ClientID", clientId);

                        // Execute the update
                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Client removal successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
