using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestStorage.Dto;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestStorage;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestStorage.Query.GetById
{
    public class GetTestStorageByIdHandler : IRequestHandler<GetTestStorageByIdQuery, TestStorageDto>
    {
        private readonly ITestStorageQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestStorageByIdHandler(ITestStorageQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestStorageDto> Handle(GetTestStorageByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestStorageDto>(data);
        }
    }
}
