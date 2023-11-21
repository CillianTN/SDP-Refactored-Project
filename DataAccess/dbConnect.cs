using System;
using System.Data.SqlClient;

namespace DogGroomSystem22
{
    public class dbConnect
    {
        private static dbConnect instance;
        public const string sqlConnectionString = "Server=DESKTOP-5SO1FRF;Database=DGSDB;User Id=cillian;Password=admin;";

        private dbConnect() { }

        public static dbConnect Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new dbConnect();
                }
                return instance;
            }
        }

        public SqlConnection getSqlConnection()
        {
            return new SqlConnection(sqlConnectionString);
        }
    }
}
