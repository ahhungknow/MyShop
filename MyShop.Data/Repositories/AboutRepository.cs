using MyShop.Data.Infrastructure;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public interface IAboutRepository:IRepository<About>
    {

    }
    public class AboutRepository : RepositoryBase<About>,IAboutRepository
    {
        public AboutRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}