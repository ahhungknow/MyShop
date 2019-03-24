using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        public CustomerRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}