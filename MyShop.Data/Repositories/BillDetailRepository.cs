using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class BillDetailRepository : RepositoryBase<BillDetail>
    {
        public BillDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}