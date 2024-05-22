using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Query.GetById
{
    public class GetTestVolumeByIdHandler : IRequestHandler<GetTestVolumeByIdQuery, TestVolumeDto>
    {
        private readonly ITestVolumeQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestVolumeByIdHandler(ITestVolumeQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestVolumeDto> Handle(GetTestVolumeByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestVolumeDto>(data);
        }
    }
}
