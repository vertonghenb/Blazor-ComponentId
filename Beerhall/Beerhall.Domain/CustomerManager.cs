using Beerhall.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beerhall.Core
{
    public class CustomerManager : ICustomerManager
    {
        private readonly BreweryDbContext _dbContext;

        public CustomerManager(BreweryDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Customer> GetDetailsAsync(int id)
        {
            return await _dbContext.Customers.FindAsync(id);
        }

        public async Task<IReadOnlyList<Customer>> GetIndexAsync()
        {
            return await _dbContext.Customers.OrderBy(x => x.Name).Take(50).AsNoTracking().ToListAsync();
        }
    }
}
