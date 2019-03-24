using MyShop.Data.Infrastructure;
using MyShop.Model.Models;
using System;

namespace MyShop.Data.Repositories
{
    public interface IAccountRepository:IRepository<Account>
    {
        bool ConfirmLogin(Account account);

        bool Register(Account account);
    }

    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public bool ConfirmLogin(Account account)
        {
            throw new NotImplementedException();
        }

        public bool Register(Account account)
        {
            throw new NotImplementedException();
        }
    }
}