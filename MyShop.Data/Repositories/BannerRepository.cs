using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class BannerRepository : RepositoryBase<Banner>
    {
        public BannerRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}