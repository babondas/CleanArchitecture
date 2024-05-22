using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IAccount;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Query.Get
{
    public class GetAccountHandler : IRequestHandler<GetAccountQuery, List<AccountDto>>
    {
        //contrl .
        private readonly IAccountRepositoryQuey _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetAccountHandler(IAccountRepositoryQuey repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<AccountDto>> Handle(GetAccountQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            //var testList = tests.Select(x => new TestDto 
            //{ 
            //    Author =x.Author, 
            //    Name = x.Name,
            //    Description= x.Description, 
            //    Id=x.Id
            //}).ToList();

            var finalData = _mapper.Map<List<AccountDto>>(data);

            return finalData;
        }
    }
}
