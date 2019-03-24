using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class SlideRepository : RepositoryBase<Slide>
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}