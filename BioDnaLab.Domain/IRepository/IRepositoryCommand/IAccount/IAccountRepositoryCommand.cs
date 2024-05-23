using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount
{
    public interface IAccountRepositoryCommand : IBaseRepositoryCommand<AccountEntity, long>
    {
        Task<AccountEntity> UpdateAsync(long id, AccountEntity entity);
    }
}
