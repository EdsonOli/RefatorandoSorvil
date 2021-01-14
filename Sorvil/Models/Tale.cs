using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorvil.Models
{
    public class Tale
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public Book Book { get; set; }
        public Saga Saga { get; set; }
        public List<Persona> Personas { get; set; }
    }
}
