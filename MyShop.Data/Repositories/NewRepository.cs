using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public interface INewRepository:IRepository<New>
    {

    }
    public class NewRepository : RepositoryBase<New>,INewRepository
    {
        public NewRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}