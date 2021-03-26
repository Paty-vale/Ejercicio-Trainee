using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using AplicacionSOAP.ServicioPersona;

namespace AplicacionSOAP
{
    public partial class AgregarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*public void addPersonaForm_InsertItem()
        {
            var item = new Persona();

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                MessageBox.Show(item.Nombre);
                using (WebService1SoapClient svc = new ServicioPersona.WebService1SoapClient())
                {
                    svc.AddPersona(item);
                }
            }
        }*/

        public void MyButton_Click(Object sender, EventArgs e)
        {
            string nombre = TextBox1.Text;
            using (WebService1SoapClient svc = new ServicioPersona.WebService1SoapClient())
            {
                svc.AddPersona(nombre);
            }
        }
    }
}