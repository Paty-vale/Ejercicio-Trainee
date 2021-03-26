using System.Data.Entity;

namespace AplicacionSOAP.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base()
        {

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ContextoPersona>());
        }
        public DbSet<Persona> Personas { get; set; }

        public void AddPersona(Persona per)
        {
            Personas.Add(per);
        }

        public void deletePersona(Persona per)
        {
            Personas.Remove(per);
        }
    }
}