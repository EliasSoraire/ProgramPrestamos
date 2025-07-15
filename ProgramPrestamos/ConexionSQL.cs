using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPrestamos
{
    public class ConexionSQL
    {
        private readonly string cadenaConexion;

        public ConexionSQL()
        {
            cadenaConexion = "Server=(localdb)\\MSSQLLocalDB;Database=PrestamoBDD;Trusted_Connection=True;";
        }

        public SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}", "Error de Conexión",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // NO ESCRIBIR NINGUNA CONSULTA AQUI

        // NO ESCRIBIR NADA DE CODIGO EN ESTA CLASE
    }
}
