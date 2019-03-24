using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class AboutRepository : RepositoryBase<About>
    {
        public AboutRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}