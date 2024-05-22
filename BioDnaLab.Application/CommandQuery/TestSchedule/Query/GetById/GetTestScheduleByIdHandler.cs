using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using BioDnaLab.Application.CommandQuery.TestStorage.Dto;
using BioDnaLab.Application.CommandQuery.TestStorage.Query.GetById;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSchedule;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestStorage;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Query.GetById
{
    public class GetTestScheduleByIdHandler : IRequestHandler<GetTestScheduleByIdQuery, TestScheduleDto>
    {
        private readonly ITestScheduleQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestScheduleByIdHandler(ITestScheduleQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestScheduleDto> Handle(GetTestScheduleByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestScheduleDto>(data);
        }
    }
}
