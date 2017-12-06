using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class MateriaDAO
    {
        public List<Materia> ListaMaterias(int idCarrera)
        {
            List<Materia> lista = new List<Materia>();

            try
            {
                String sentencia = "select id, nombre from materias where idcarrera = @idcarrera;";
                MySqlCommand cm = new MySqlCommand(sentencia);
                cm.Parameters.AddWithValue("idcarrera", idCarrera);
                Conexion con = new Conexion();
                DataTable dtMaterias = con.ejecutarConsulta(cm);
                Materia materia = null;

                //Recorrer las filas obtenidas por la consulta
                //para llenar la lista de Categorias
                foreach (DataRow fila in dtMaterias.Rows)
                {
                    materia = new Materia(
                        int.Parse(fila["id"].ToString()),
                        fila["nombre"].ToString()
                    );

                    lista.Add(materia);

                }
                return lista;
            }
            catch
            {
                return lista;
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
