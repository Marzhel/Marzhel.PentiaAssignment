using System.Collections.Generic;
using System.Threading.Tasks;
using Marzhel.PentiaAssignment.Models;

namespace Marzhel.PentiaAssignment.Repositories
{
    public interface ICustomerRepository
    {
        Task<ICollection<Customer>> GetAsync();

        Task<Customer> GetAsync(int id);

        Task<ICollection<Customer>> GetByNameAsync(string name);

        Task<ICollection<Customer>> GetByStreetAsync(string street);

        Task<ICollection<Customer>> GetByCarModelAsync(string carModel);

        Task<ICollection<Customer>> GetByCarMakeAsync(string carMake);

        Task<ICollection<Customer>> GetBySalesPersonNameAsync(string salesPersonName);
    }
}
