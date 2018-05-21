using System.Data.Entity;
using Marzhel.PentiaAssignment.Models;

namespace Marzhel.PentiaAssignment.Contexts
{
    public class SalesContext : DbContext
    {
        // The static consturctor is used to set the initializer for the sales context. This will
        // populate the database with some test data.
        static SalesContext()
        {
            Database.SetInitializer(new SalesContextInitializer());
        }

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
