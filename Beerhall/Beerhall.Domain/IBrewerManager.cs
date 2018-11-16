using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Beerhall.Core
{
    public interface IBrewerManager
    {
        Task<IReadOnlyList<Brewer>> GetIndexAsync();
        Task<Brewer> GetDetailsAsync(int id);
    }
}
