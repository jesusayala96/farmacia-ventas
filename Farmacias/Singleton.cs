using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Farmacias
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=JESUSAYALA-PC\SQLEXPRESS;initial catalog=farmacias;integrated security=true");

        static Singleton() { }
        private Singleton() { }

        public static Singleton Instance
        {
            get

            {
                if(instance==null)
                {
                   Singleton instance = new Singleton();
                }

                return instance;
            }

        }

        public SqlConnection GetDBConnection(){
            return connection;

        }

        private void CloseDBConnection(){
            connection.Close();
        }

        public void OpenDBConnection(){
            if(connection.State == System.Data.ConnectionState.Open)
            {
                CloseDBConnection();
            }
            connection.Open();
        }
    }
}
