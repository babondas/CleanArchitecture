using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using BioDnaLab.Infrastructure.Data;
using BioDnaLab.Infrastructure.Repository.Command.Base;

namespace BioDnaLab.Infrastructure.Repository.Command.Account
{
    public class AccountRepositoryCommand : BaseRepositoryCommand<AccountEntity, long>, IAccountRepositoryCommand
    {
        public AccountRepositoryCommand(BioDnaLabContext context) : base(context)
        {

        }

        public async Task<AccountEntity> UpdateAsync(long id, AccountEntity entity)
        {
            // Find the existing entity in the context using the provided id
            var existingEntity = await _context.Set<AccountEntity>().FindAsync(id);
            if (existingEntity == null)
            {
                return null; // Entity not found
            }

            // Manually copy each property value from the entity to the existingEntity
            existingEntity.Name = entity.Name;
            existingEntity.Email = entity.Email;
            existingEntity.PrimaryContactNumber = entity.PrimaryContactNumber;
            existingEntity.SecondaryContactNumber = entity.SecondaryContactNumber;
            existingEntity.Address = entity.Address;
            existingEntity.ModifiedDate = DateTime.Now;
            existingEntity.ModifiedBy = 1;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return existingEntity;
        }
    }
}
