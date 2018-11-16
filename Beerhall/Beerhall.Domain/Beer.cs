using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beerhall.Core
{
    public class Beer : Entity
    {
        #region Properties
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal AlcoholByVolume { get; private set; }
        public decimal Price { get; private set; }
        #endregion

        #region Constructors
        private Beer() { }
        public Beer(string name, string description, decimal price, decimal alcoholByVolume)
        {
            Guard.Against.NullOrWhiteSpace(name, nameof(name));

            Name = name;
            Description = description;
            Price = price;
            AlcoholByVolume = alcoholByVolume;
        }
        #endregion
    }
}
