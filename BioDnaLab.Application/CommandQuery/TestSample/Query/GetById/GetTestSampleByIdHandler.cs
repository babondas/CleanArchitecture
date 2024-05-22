using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using BioDnaLab.Application.CommandQuery.TestSchedule.Query.GetById;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSample;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSchedule;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestSample.Query.GetById
{
    public class GetTestSampleByIdHandler : IRequestHandler<GetTestSampleByIdQuery, TestSampleDto>
    {
        private readonly ITestSampleQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestSampleByIdHandler(ITestSampleQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestSampleDto> Handle(GetTestSampleByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestSampleDto>(data);
        }
    }
}
