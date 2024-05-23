using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IAccount;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Query.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Repository.Query.Account
{
    public class AccountRepositoryQuery : BaseRepositoryQuery<AccountEntity, long>, IAccountRepositoryQuey
    {
        public AccountRepositoryQuery(BioDnaLabContext context) : base(context)
        {
        }

        public async Task<AccountEntity> GetByEmailAndPasswordAsync(string email, string password)
        {
            return await _context.Set<AccountEntity>()
                            .FirstOrDefaultAsync(account => account.Email == email
                            && account.Password == password
                            && account.IsActive == true);
        }
    }
}
