using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class BillRepository : RepositoryBase<Bill>
    {
        public BillRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}