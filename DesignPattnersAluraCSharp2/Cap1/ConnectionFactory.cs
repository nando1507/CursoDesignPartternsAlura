using System.Data;
using System.Data.SqlClient;

namespace DesignPattnersAluraCSharp2.Cap1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-UVIN3NU;Initial Catalog=Particular;Integrated Security=True";
            connection.Open();
            return connection;
        }
    }
}
