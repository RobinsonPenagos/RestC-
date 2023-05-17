using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSCrear
{
    /// <summary>
    /// Descripción breve de WSCrear
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCrear : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "La Aplicacion de Robin";
        }
            [WebMethod]
        public DataSet WSListado()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MSI;Initial catalog=DBUDC; Integrated Security=true";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]

        public DataSet WSConsulta(String Nombre)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MSI;Initial catalog=DBUDC; Integrated Security=true";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student WHERE FirstName= '"+ Nombre +"'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

    }
}
