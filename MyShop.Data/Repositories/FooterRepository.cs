using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class FooterRepository : RepositoryBase<Footer>
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}