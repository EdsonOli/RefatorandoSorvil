using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorvil.Models
{
    public class MyBook
    {
        public int Id { get; set; }
        public Grade Grade { get; set; }
        public Status Status { get; set; }
        public bool Favorite { get; set; }
        public Book Book { get; set; }

    }
}
