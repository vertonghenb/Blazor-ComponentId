using Ardalis.GuardClauses;

namespace Beerhall.Core
{
    public class Address
    {
        public string Street { get; private set; }
        public string Country { get; private set; }

        public Address(string street, string country)
        {
            Guard.Against.NullOrWhiteSpace(street, nameof(street));
            Guard.Against.NullOrWhiteSpace(country, nameof(country));

            Street = street;
            Country = country;
        }
    }
}