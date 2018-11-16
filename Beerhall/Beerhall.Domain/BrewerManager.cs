using Beerhall.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beerhall.Core
{
    public class BrewerManager : IBrewerManager
    {
        private readonly BreweryDbContext _dbContext;

        public BrewerManager(BreweryDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Brewer> GetDetailsAsync(int id)
        {
            return await _dbContext.Brewers.Include(x => x.Beers)
                                    .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IReadOnlyList<Brewer>> GetIndexAsync()
        {
            return await _dbContext.Brewers.OrderBy(x => x.Name).Take(50).AsNoTracking().ToListAsync();
        }
    }
}
