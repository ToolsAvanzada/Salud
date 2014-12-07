using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using WebAutos.model;

namespace WebAutos
{
    public partial class WebAutos : System.Web.UI.Page
    {
        private static Automovil4 db = new Automovil4();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string Grabar(string marca, string modelo, string chasis, string color, string tipo)
        {
            Automovil objAutomovil = new Automovil();
            
            objAutomovil.Marca = marca;
            objAutomovil.Modelo = modelo;
            objAutomovil.Chasis = chasis;
            objAutomovil.Color= color;
            objAutomovil.Tipo = tipo;
            
            db.Automovil.Add(objAutomovil);

            db.SaveChanges();

            return "OK";

            

        }
        [WebMethod]
        public static List<Automovil> listar()
        {
            return db.Automovil.ToList();
        }
    }
}