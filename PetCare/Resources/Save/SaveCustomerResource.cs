﻿using PetCare.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetCare.Resources
{
    public class SaveCustomerResource : User
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MinLength(7)]
        [MaxLength(7)]
        public string Document { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(9)]
        [MaxLength(9)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Age { get; set; }

    }
}