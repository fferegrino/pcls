using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PclCalculadora.Web
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {

            var calculadora = new Calculadora();
            calculadora.SetPrimerNumero(Int32.Parse(tbNumero1.Text));
            calculadora.SetSegundoNumero(Int32.Parse(tbNumero2.Text));

            resultado.Text = calculadora.Calcula().ToString();
        }
    }
}