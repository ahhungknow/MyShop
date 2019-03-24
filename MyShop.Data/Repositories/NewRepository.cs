using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class NewRepository : RepositoryBase<New>
    {
        public NewRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}