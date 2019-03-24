using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public interface IBillRepository:IRepository<Bill>
    {

    }
    public class BillRepository : RepositoryBase<Bill>,IBillRepository
    {
        public BillRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}