﻿using System;
namespace E_Commerce.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string Zipcode { get; set; }

        public string City { get; set; }

        public string Cart_guid { get; set; }

        public string Email { get; set; }
    }
}