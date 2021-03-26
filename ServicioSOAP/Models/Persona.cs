using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicacionSOAP.Models
{
    public class Persona
    {
        public Persona() { }
        public Persona(string Nombre)
        {
            this.Nombre = Nombre;
        }
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}