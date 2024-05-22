using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IRepositoryCommandBase;

namespace BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount
{
    public interface IAccountRepositoryCommand : IBaseRepositoryCommand<AccountEntity, int>
    {
        // You can add more customer-specific methods here if needed
    }
}
