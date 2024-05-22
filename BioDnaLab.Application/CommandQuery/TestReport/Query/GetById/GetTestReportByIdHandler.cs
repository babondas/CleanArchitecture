using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestReport.Dto;
using BioDnaLab.Application.CommandQuery.TestReport.Query.Get;
using BioDnaLab.Application.CommandQuery.TestSample.Dto;
using BioDnaLab.Application.CommandQuery.TestSample.Query.GetById;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestReport;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestSample;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestReport.Query.GetById
{
    public class GetTestReportByIdHandler : IRequestHandler<GerTestReportByIdQuery, TestReportDto>
    {
        private readonly ITestReportQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestReportByIdHandler(ITestReportQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestReportDto> Handle(GerTestReportByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestReportDto>(data);
        }
    }
}