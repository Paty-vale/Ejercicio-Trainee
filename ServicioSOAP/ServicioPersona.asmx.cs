using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services;
using AplicacionSOAP.Models;
using System.Web.UI.WebControls;

namespace AplicacionSOAP
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioPersona : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Persona> PersonasGetData()
        {
            Contexto cp = new Contexto();
            return cp.Personas.ToList();
        }

        [WebMethod]
        public void AddPersona(string nom)
        {
            Persona p = new Persona(nom);
            using (Contexto db = new Contexto())
            {
                db.Personas.Add(p);
                db.SaveChanges();
            }
        }

    }
}
