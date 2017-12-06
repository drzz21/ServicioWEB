using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDAO
    {

        public Usuario Login(string us,string pw)
        {
            Usuario usuario = null;

            try
            {
                String sentencia = "select * from usuarios where usuario = @user and password = @pass;";
                MySqlCommand cm = new MySqlCommand(sentencia);
                cm.Parameters.AddWithValue("user", us);
                cm.Parameters.AddWithValue("pass", pw);
                Conexion con = new Conexion();
                DataTable dtUsuarios = con.ejecutarConsulta(cm);

                //Verificar si la consulta regresó resultados
                // para llenar el objeto
                if (dtUsuarios != null && dtUsuarios.Rows.Count > 0)
                {
                    //Se obtiene la fila de la categoria buscada
                    DataRow fila = dtUsuarios.Rows[0];

                    usuario = new Usuario(
                        fila["usuario"].ToString(),
                        fila["nombrecompleto"].ToString()
                    );
                }
                return usuario;
            }
            catch
            {
                return usuario;
            }
            finally
            {
                //Solo intentar cerrar la conexión cuando si se encuentra abierta
                if (Conexion.conexion != null)
                {
                    Conexion.conexion.Close();
                }
            }
        }

    }
}
