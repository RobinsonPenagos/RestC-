using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace WSConsumirServicio
{
    public partial class WSListadoEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WSEstudiante.WSCrearSoapClient WS= new WSEstudiante.WSCrearSoapClient();
            DataSet ds = WS.WSListado();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WSEstudiante.WSCrearSoapClient WS = new WSEstudiante.WSCrearSoapClient();
            DataSet ds = WS.WSConsulta(TextBox1.Text);
            GridView1.DataSource= ds.Tables[0];
            GridView1.DataBind();
        }
    }
}