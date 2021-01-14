using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorvil.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public string PublishingCompany { get; set; }
        public Author Author { get; set; }
        public Saga Saga { get; set; }
        public List<string> Genre { get; set; }
        public int NumberOfPages { get; set; }
        public int YearOfPublication { get; set; }
    }
}
