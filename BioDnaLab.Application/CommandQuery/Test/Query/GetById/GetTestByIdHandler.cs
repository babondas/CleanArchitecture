using AutoMapper;
using BioDnaLab.Application.CommandQuery.Test.Dto;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Test.Query.GetById
{
    public class GetTestByIdHandler : IRequestHandler<GetTestByIdQuery, TestDto>
    {
        private readonly ITestRepositoryQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestByIdHandler(ITestRepositoryQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestDto> Handle(GetTestByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestDto>(data);
        }
    }
}