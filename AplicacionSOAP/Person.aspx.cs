using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using AplicacionSOAP.ServicioPersona;

namespace AplicacionSOAP
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> nombres = new List<string>();
            List<Persona> personas;

            using (WebService1SoapClient svc = new ServicioPersona.WebService1SoapClient())
            {
                personas = svc.PersonasGetData().ToList();
            }
            foreach (Persona p in personas)
            {
                nombres.Add(p.Nombre);
            }
            // Generate rows and cells.           
            int numrows = nombres.Count;
            int numcells = 1;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl(nombres[j]));
                    r.Cells.Add(c);
                }
                Table1.Rows.Add(r);
            }
        }

        public List<string> personasObtenerDatos()
        {
            List<string> nombres = new List<string>();
            List<Persona> personas;
            using (WebService1SoapClient svc = new ServicioPersona.WebService1SoapClient())
            {
                svc.ClientCredentials.Windows.AllowedImpersonationLevel =
                System.Security.Principal.TokenImpersonationLevel.Impersonation;
                personas = svc.PersonasGetData().ToList();
            }
            foreach (Persona p in personas)
            {
                nombres.Add(p.Nombre);
            }
            return nombres;
        }

    }
}