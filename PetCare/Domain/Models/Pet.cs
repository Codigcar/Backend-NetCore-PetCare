﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCare.Domain.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Breed { get; set; }
        public string Photo { get; set; }
        public string Sex { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
