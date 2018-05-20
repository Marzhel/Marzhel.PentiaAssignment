using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using Marzhel.PentiaAssignment.Contexts;
using Marzhel.PentiaAssignment.Models;

namespace Marzhel.PentiaAssignment.Services
{
    public class CustomerService : ICustomerService, IDisposable
    {
        private readonly SalesContext _salesContext;

        public CustomerService(IDbContextFactory<SalesContext> salesContextFactory)
        {
            _salesContext = salesContextFactory.Create();
        }

        public void Dispose()
        {
            _salesContext.Dispose();
        }

        public async Task<ICollection<Customer>> GetAsync()
        {
            return await _salesContext.Customers.ToListAsync();
        }

        public Task<Customer> GetAsync(int id)
        {
            return _salesContext.Customers.FirstOrDefaultAsync(customer => customer.CustomerId == id);
        }

        public async Task<ICollection<Customer>> GetByStreetAsync(string street)
        {
            var query = from customer in _salesContext.Customers
                        where customer.Address.Line1 == street
                        select customer;

            return await query.ToListAsync();
        }

        public async Task<ICollection<Customer>> GetByCarMake(string carMake)
        {
            var query = from purchase in _salesContext.CarPurchases
                        where purchase.Car.Make == carMake
                        select purchase.Customer;

            return await query.ToListAsync();
        }

        public async Task<ICollection<Customer>> GetByCarModel(string carModel)
        {
            var query = from purchase in _salesContext.CarPurchases
                        where purchase.Car.Model == carModel
                        select purchase.Customer;

            return await query.ToListAsync();
        }

        public async Task<ICollection<Customer>> GetByNameAsync(string name)
        {
            var query = from customer in _salesContext.Customers
                        where customer.Name == name
                        select customer;

            return await query.ToListAsync();
        }

        public async Task<ICollection<Customer>> GetBySalesPersonName(string salesPersonName)
        {
            var query = from purchase in _salesContext.CarPurchases
                        where purchase.SalesPerson.Name == salesPersonName
                        select purchase.Customer;

            return await query.ToListAsync();
        }
    }
}
