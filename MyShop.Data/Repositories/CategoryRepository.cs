using MyShop.Data.Infrastructure;
using MyShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Data.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetByAlias(string alias);
    }

    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Category> GetByAlias(string alias)
        {
            return DbContext.Categories.Where(x => x.Link == alias);
        }
    }
}