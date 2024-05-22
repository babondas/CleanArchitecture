using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IRepositoryBase;

namespace BioDnaLab.Domain.IRepository.IRepositoryQuery.IAccount
{
    public interface IAccountRepositoryQuey : IBaseRepositoryQuery<AccountEntity, int>
    {
        Task<AccountEntity> GetByEmailAndPasswordAsync(string email, string password);
    }
}
