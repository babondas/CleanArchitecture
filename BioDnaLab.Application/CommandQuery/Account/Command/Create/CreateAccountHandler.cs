using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Command.Create
{
    public class CreateTestVolumeHandler : IRequestHandler<CreateAccountCommand, AccountDto>
    {
        private readonly IAccountRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestVolumeHandler(IAccountRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AccountDto> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var entity = new AccountEntity()
            {
                Name = request.Name,
                Email = request.Email,
                PrimaryContactNumber = request.PrimaryContactNumber,
                SecondaryContactNumber = request.SecondaryContactNumber,
                Password = request.Password,
                Address = request.Address,
                Description = request.Description,
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                CreatedBy = 1,
                ModifiedBy = null,
                IsActive = true
            };

            var result = await _repository.AddAsync(entity);
            return _mapper.Map<AccountDto>(result);
        }
    }
}
