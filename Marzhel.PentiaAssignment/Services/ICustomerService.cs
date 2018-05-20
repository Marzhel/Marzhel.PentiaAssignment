using System.Collections.Generic;
using System.Threading.Tasks;
using Marzhel.PentiaAssignment.Models;

namespace Marzhel.PentiaAssignment.Services
{
    public interface ICustomerService
    {
        Task<ICollection<Customer>> GetAsync();

        Task<Customer> GetAsync(int id);

        Task<ICollection<Customer>> GetByNameAsync(string name);

        Task<ICollection<Customer>> GetByStreetAsync(string street);

        Task<ICollection<Customer>> GetByCarModel(string carModel);

        Task<ICollection<Customer>> GetByCarMake(string carMake);

        Task<ICollection<Customer>> GetBySalesPersonName(string salesPersonName);
    }
}
