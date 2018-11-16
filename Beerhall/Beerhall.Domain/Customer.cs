using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beerhall.Core
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public string VatNumber { get; private set; }
        public Address Address { get; private set; }

        private Customer() { }
        public Customer(string name, string vatNumber, Address address)
        {
            Guard.Against.NullOrWhiteSpace(name, nameof(name));
            Name = name;
            VatNumber = vatNumber;
            Address = address;
        }
    }
}
