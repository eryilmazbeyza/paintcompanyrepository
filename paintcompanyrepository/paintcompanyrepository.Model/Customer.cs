﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintcompanyrepository.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
    }
}
