using System.Collections.Generic;
using System.Threading.Tasks;
using Marzhel.PentiaAssignment.Models;

namespace Marzhel.PentiaAssignment.Repositories
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// Get a ICollection of all <see cref="Customer"/>s.
        /// </summary>
        Task<ICollection<Customer>> GetAsync();

        /// <summary>
        /// Get a specific <see cref="Customer"/> by it's ID.
        /// </summary>
        /// <param name="id">ID of <see cref="Customer"/> to get.</param>
        Task<Customer> GetAsync(int id);

        /// <summary>
        /// Get all <see cref="Customer"/>s with the provided firstname.
        /// </summary>
        /// <param name="name">Firstname of <see cref="Customer"/>s to get.</param>
        Task<ICollection<Customer>> GetByNameAsync(string name);

        /// <summary>
        /// Get all <see cref="Customer"/>s with the provided street. Street line 1 will be used for comparison.
        /// </summary>
        /// <param name="street">Street line 1 to get <see cref="Customer"/>s with.</param>
        Task<ICollection<Customer>> GetByStreetAsync(string street);

        /// <summary>
        /// Get all <see cref="Customer"/>s that have purchased a <see cref="Car"/> of the provided model.
        /// </summary>
        /// <param name="carModel">
        /// Name of <see cref="Car"/> model to get <see cref="Customer"/>s for.
        /// </param>
        Task<ICollection<Customer>> GetByCarModelAsync(string carModel);

        /// <summary>
        /// Get all <see cref="Customer"/>s that have purchased a <see cref="Car"/> of the provided make.
        /// </summary>
        /// <param name="carModel">
        /// Name of <see cref="Car"/> make to get <see cref="Customer"/>s for.
        /// </param>
        Task<ICollection<Customer>> GetByCarMakeAsync(string carMake);

        /// <summary>
        /// Get all <see cref="Customer"/>s that have purchased a car from the <see
        /// cref="SalesPerson"/> with the provided name.
        /// </summary>
        /// <param name="salesPersonName">
        /// Name of <see cref="SalesPerson"/> to get <see cref="Customer"/>s for.
        /// </param>
        /// <returns></returns>
        Task<ICollection<Customer>> GetBySalesPersonNameAsync(string salesPersonName);
    }
}
