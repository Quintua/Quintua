
using QUINTUACLASS;
using System.Data.SqlClient;

namespace cmd
{
    internal class Data
    {
        static string connectionString
        = "Data Source =DESKTOP-8JBNA1P\\MSSQLSERVER01; Initial Catalog = QUINTUA; Integrated Security = True;"; //Local Connection
        //= "Server=tcp:4.193.106.92,1433;Database=PUPHubPoints;User Id=sa;Password=PUPHUB123!;"; //Server Connection
        static SqlConnection sqlConnection;


        public Data()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<programa> Table_1()
        {
            var selectStatement = "SELECT * FROM Table_1";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var programas = new List<programa>();

            while (reader.Read())
            {
                programas.Add(new programa
                {
                    phoneBrand = reader["phoneBrand"].ToString(),
                    devicereleasedate = Convert.ToInt32(reader["devicereleasedate"].ToString()),
                    devicetype = reader["devicetype"].ToString(),
                    devicemodel = reader["devicemodel"].ToString()
                });
            }

            sqlConnection.Close();
            return programas;
        }
    }
}

