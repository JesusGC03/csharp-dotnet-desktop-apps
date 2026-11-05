using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BDFamosos
{
    internal class CFamosoDAL
    {
        // Cadena de conexión hacia la instancia LocalDB
        private string strConexion = @"Data Source=np:\\.\pipe\LOCALDB#1776ACDE\tsql\query;Initial Catalog=bd_famosos;Integrated Security=True";
    
        public CFamosoDAL() { }

        // Obtenemos todas las filas
        public ColCFamosos ObtenerFilasFamosos()
        {
            try
            {
                // Using asegura que la conexión se cierre y libere
                using (SqlConnection Conexion = new SqlConnection(strConexion))
                {
                    SqlCommand OrdenSql = new SqlCommand("stproObtenerFilasFamosos", Conexion);
                    OrdenSql.CommandType = CommandType.StoredProcedure;

                    ColCFamosos colFamosos = new ColCFamosos();

                    Conexion.Open();
                    SqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CFamosoBO fila = new CFamosoBO(
                            (int)lector["ID"],
                            (string)lector["nombre"],
                            (string)lector["apellidos"],
                            (DateTime)lector["cumple"],
                            (string)lector["imagen"]
                        );
                        colFamosos.Add(fila);
                    }

                    return colFamosos;
                }
            }
            catch (SqlException err){
                throw new ApplicationException("Error SELECT famoso: " + err.Message);
            }
        }

        public void ActualizarFamosos(CFamosoBO bo)
        {
            try
            {
                using (SqlConnection Conexion = new SqlConnection(strConexion))
                {
                    SqlCommand OrdenSql = new SqlCommand("stproActualizarFamosos", Conexion);
                    OrdenSql.CommandType = CommandType.StoredProcedure;

                    // Pasamos los parámetros requeridos por el procedimiento
                    OrdenSql.Parameters.AddWithValue("@ID", bo.Id);
                    OrdenSql.Parameters.AddWithValue("@nombre", bo.Nombre);
                    OrdenSql.Parameters.AddWithValue("@apellidos", bo.Apellidos);
                    OrdenSql.Parameters.AddWithValue("@cumple", bo.Cumple);
                    OrdenSql.Parameters.AddWithValue("@imagen", bo.Imagen);

                    Conexion.Open();
                    OrdenSql.ExecuteNonQuery(); // Ejecuta la orden UPDATE
                }
            }catch (SqlException err)
            {
                throw new ApplicationException("Error UPDATE famoso: " + err.Message);
            }
        }
    }
}
