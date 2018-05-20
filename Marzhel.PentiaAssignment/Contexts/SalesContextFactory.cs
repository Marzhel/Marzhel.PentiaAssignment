using System.Data.Entity.Infrastructure;

namespace Marzhel.PentiaAssignment.Contexts
{
    public class SalesContextFactory : IDbContextFactory<SalesContext>
    {
        public SalesContext Create()
        {
            return new SalesContext("DefaultConnection");
        }
    }
}
