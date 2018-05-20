using System.Data.Entity;
using Marzhel.PentiaAssignment.Models;

namespace Marzhel.PentiaAssignment.Contexts
{
    public class SalesContext : DbContext
    {
        public SalesContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<CarPurchase> CarPurchases { get; set; }
        public IDbSet<SalesPerson> SalesPeople { get; set; }
        public IDbSet<Car> Cars { get; set; }
        public IDbSet<CarExtra> CarExtras { get; set; }
    }
}
