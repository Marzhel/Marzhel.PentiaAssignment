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
            return _salesContext.Customers.FirstOrDefaultAsync(customer => customer.Id == id);
        }

        public async Task<ICollection<Customer>> GetByStreetAsync(string street)
        {
            return await _salesContext.Customers
                .Where(customer => customer.Address.Line1 == street)
                .ToListAsync();
        }

        public async Task<ICollection<Customer>> GetByCarMakeAsync(string carMake)
        {
            return await _salesContext.CarPurchases
                .Where(purchase => purchase.Car.Make == carMake)
                .Select(purchase => purchase.Customer)
                .ToListAsync();
        }

        public async Task<ICollection<Customer>> GetByCarModelAsync(string carModel)
        {
            return await _salesContext.CarPurchases
                .Where(purchase => purchase.Car.Model == carModel)
                .Select(purchase => purchase.Customer)
                .ToListAsync();
        }

        public async Task<ICollection<Customer>> GetByNameAsync(string name)
        {
            return await _salesContext.Customers
                .Where(customer => customer.Name == name)
                .ToListAsync();
        }

        public async Task<ICollection<Customer>> GetBySalesPersonNameAsync(string salesPersonName)
        {
            return await _salesContext.CarPurchases
                .Where(purchase => purchase.SalesPerson.Name == salesPersonName)
                .Select(purchase => purchase.Customer)
                .ToListAsync();
        }
    }
}
