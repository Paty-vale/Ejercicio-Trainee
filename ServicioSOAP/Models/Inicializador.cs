using System.Collections.Generic;
using System.Data.Entity;
using AplicacionSOAP.Models;

namespace AplicacionSOAP.Models
{
    public class Inicializador : DropCreateDatabaseIfModelChanges<Contexto>
    {
        protected override void Seed(Contexto context)
        {
            GetPersonas().ForEach(p => context.Personas.Add(p));
        }

        private static List<Persona> GetPersonas()
        {
            var per = new List<Persona> {
                new Persona("Pedro"),
                new Persona("Luciana"),
                new Persona("Lucas"),
                new Persona("Roberto"),
                new Persona("Claudia"),
            };

            return per;
        }
    }
}