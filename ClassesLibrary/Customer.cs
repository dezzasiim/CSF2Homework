﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public Customer() { }

        public override string ToString()
        {
            return string.Format($"{CustomerId} belongs to {FirstName} {LastName} and their contact info is {ContactInformation}");
        }

    }
}
