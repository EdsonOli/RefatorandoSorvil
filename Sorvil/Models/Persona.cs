﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorvil.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Book book { get; set; }
    }
}
