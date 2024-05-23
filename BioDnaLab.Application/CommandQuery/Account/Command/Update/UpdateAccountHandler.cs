using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestStorage.Command.Update;
using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Command.Update
{
    public class UpdateAccountHandler : IRequestHandler<UpdateAccountCommand, long>
    {
        private readonly IAccountRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateAccountHandler(IAccountRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountEntity()
            {
                Name=request.Name,
                Email=request.Email,
                PrimaryContactNumber=request.PrimaryContactNumber,
                SecondaryContactNumber  =request.SecondaryContactNumber,
                Address=request.Address,
                Description =request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
                IsActive=true
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}

