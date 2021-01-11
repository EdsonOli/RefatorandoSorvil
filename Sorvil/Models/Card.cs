using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorvil.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime Date { get; set; }
        public bool OpenOrClosed { get; set; }
        public int Page { get; set; }
    }
}
