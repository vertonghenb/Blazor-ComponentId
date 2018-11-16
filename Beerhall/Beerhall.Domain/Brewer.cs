using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beerhall.Core
{
    public class Brewer : Entity
    {
        #region Fields
        private ICollection<Beer> _beers = new List<Beer>();        
        #endregion

        #region Properties
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Email { get; private set; }
        public DateTime? EstablishedDate { get; private set; }
        public Address Address { get; private set; }
        public IEnumerable<Beer> Beers => _beers.AsEnumerable(); 
        #endregion

        #region Constructors
        private Brewer() { }
        public Brewer(string name, string descritpion, string email, Address address, DateTime? establishedDate)
        {
            Guard.Against.NullOrWhiteSpace(name, nameof(name));
            Guard.Against.NullOrWhiteSpace(email, nameof(email));
            Name = name;
            Description = descritpion;
            Address = address;
            EstablishedDate = establishedDate;
        }
        #endregion

        #region Methods
        public Beer AddBeer(string name, string description,decimal price, decimal alcoholByVolume)
        {
            Beer beer = new Beer(name, description, price, alcoholByVolume);
            _beers.Add(beer);
            return beer;
        }

        public void DeleteBeer(Beer beer)
        {
            _beers.Remove(beer);
        }
        #endregion

    }
}
