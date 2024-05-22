using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestReport.Dto;
using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using BioDnaLab.Application.CommandQuery.TestSample.Query.Get;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestReport;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSample;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestReport.Query.Get
{
    public class GetTestReportHandler : IRequestHandler<GetTestReportQuery, List<TestReportDto>>
    {
        //contrl .
        private readonly ITestReportQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestReportHandler(ITestReportQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestReportDto>> Handle(GetTestReportQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();

            var finalData = _mapper.Map<List<TestReportDto>>(data);

            return finalData;
        }
    }
}