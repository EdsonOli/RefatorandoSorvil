using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorvil.Models
{
    public class Saga
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Author> authors { get; set; }
        public string Description { get; set; }

    }
}
