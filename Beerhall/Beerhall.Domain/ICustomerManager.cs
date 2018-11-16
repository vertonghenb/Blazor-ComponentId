using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Beerhall.Core
{
    public interface ICustomerManager
    {
        Task<IReadOnlyList<Customer>> GetIndexAsync();
        Task<Customer> GetDetailsAsync(int id);
    }
}
