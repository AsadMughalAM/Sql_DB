﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCrudApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String? Address { get; set; }
        public String CNIC { get; set; }
        public String? Phone { get; set; }
        public string Designition { get; set; }
        public bool isActive { get; set; }
        public DateTime DOB { get; set; }
    }
}
