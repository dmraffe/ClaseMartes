using System.Data.SqlClient;

namespace MVC.ADO.ADM
{
    public class BaseADM
    {

        public SqlConnection conexion;
        public void Conectar()
        {
            string stringConexion = @"Data Source=localhost\SQLEXPRESS;Database=ClaseMartesDB;Trusted_Connection=True;TrustServerCertificate=True;";
            conexion = new SqlConnection(stringConexion);
        }
    }
}
