using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Query.Get
{
    public class GetTestVolumeHandler : IRequestHandler<GetTestVolumeQuery, List<TestVolumeDto>>
    {
        //contrl .
        private readonly ITestVolumeQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestVolumeHandler(ITestVolumeQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestVolumeDto>> Handle(GetTestVolumeQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            //var testList = tests.Select(x => new TestDto 
            //{ 
            //    Author =x.Author, 
            //    Name = x.Name,
            //    Description= x.Description, 
            //    Id=x.Id
            //}).ToList();

            var finalData = _mapper.Map<List<TestVolumeDto>>(data);

            return finalData;
        }
    }
}
