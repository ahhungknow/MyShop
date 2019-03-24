using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class MenuRepository : RepositoryBase<Menu>
    {
        public MenuRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}