using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnectDatabase
{
    class ConnectDB
    {
        string ConnectionString = "Data Source=PC02;Initial Catalog=Test;Integrated Security=True";

        public void InsertQuery(string Query)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            SqlCommand Cmd = new SqlCommand(Query, Connection);
            Cmd.ExecuteNonQuery();

            Connection.Close();
        }

        public SqlDataReader SelectQuery(string Query)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            SqlCommand Cmd = new SqlCommand(Query, Connection);
            SqlDataReader result = Cmd.ExecuteReader();

            return result;
        }
    }
}
