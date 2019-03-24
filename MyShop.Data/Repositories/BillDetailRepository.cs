using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public interface IBillDetailRepository:IRepository<BillDetail>
    {

    }
    public class BillDetailRepository : RepositoryBase<BillDetail>,IBillDetailRepository
    {
        public BillDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}