using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace BuscadorWEB
{
    public partial class Buscarlibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                dataListado.DataSource = NLibros.Mostrar();
                dataListado.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected void dataListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}