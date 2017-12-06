using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace nwind
{
    /// <summary>
    /// Descripción breve de WSSICENET
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSSICENET : System.Web.Services.WebService
    {

        [WebMethod]
        public string Login(string us, string pw)
        {
            return new JavaScriptSerializer().Serialize(new UsuarioDAO().Login(us, pw));
        }

        [WebMethod]
        public string MateriasPorCarrera(int idCarrera)
        {
            return new JavaScriptSerializer().Serialize(new MateriaDAO().ListaMaterias(idCarrera));
        }

    }
}
