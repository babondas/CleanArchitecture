using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestSchedule.Dto;
using BioDnaLab.Application.CommandQuery.TestStorage.Dto;
using BioDnaLab.Application.CommandQuery.TestStorage.Query.Get;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSchedule;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestStorage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Query.Get
{
    public class GetTestScheduleHandler : IRequestHandler<GetTestScheduleQuery, List<TestScheduleDto>>
    {
        //contrl .
        private readonly ITestScheduleQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestScheduleHandler(ITestScheduleQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestScheduleDto>> Handle(GetTestScheduleQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();

            var finalData = _mapper.Map<List<TestScheduleDto>>(data);

            return finalData;
        }
    }
}
