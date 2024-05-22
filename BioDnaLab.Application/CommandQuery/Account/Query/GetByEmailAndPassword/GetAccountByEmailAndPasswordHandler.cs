using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IAccount;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Account.Query.GetByEmailAndPassword
{
    public class GetAccountByEmailAndPasswordHandler : IRequestHandler<GetAccountByEmailAndPasswordQuery, AccountDto>
    {
        private readonly IAccountRepositoryQuey _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetAccountByEmailAndPasswordHandler(IAccountRepositoryQuey repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<AccountDto> Handle(GetAccountByEmailAndPasswordQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByEmailAndPasswordAsync(request.Email, request.Password);
            return _mapper.Map<AccountDto>(data);
        }
    }
}
