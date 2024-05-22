using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Base;

namespace BioDnaLab.Infrastructure.Repository.Command.Account
{
    public class AccountRepositoryCommand : BaseRepositoryCommand<AccountEntity, int>, IAccountRepositoryCommand
    {
        public AccountRepositoryCommand(BioDnaLabContext context) : base(context)
        {

        }
    }
}
