using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IAccount;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Query.GetById
{
    public class GetAccountByIdHandler : IRequestHandler<GetAccountByIdQuery, AccountDto>
    {
        private readonly IAccountRepositoryQuey _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetAccountByIdHandler(IAccountRepositoryQuey repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<AccountDto> Handle(GetAccountByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.AccountId);
            return _mapper.Map<AccountDto>(data);
        }
    }
}
