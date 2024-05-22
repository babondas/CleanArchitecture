using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestMethodology.Dto;
using BioDnaLab.Application.CommandQuery.TestReport.Dto;
using BioDnaLab.Application.CommandQuery.TestReport.Query.Get;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestMethodology;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestReport;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Query.Get
{
    public class GetTestMetholodogyHandler : IRequestHandler<GetTestMetholodogyQuery, List<TestMethodologyDto>>
    {
        //contrl .
        private readonly ITestMethodologyQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestMetholodogyHandler(ITestMethodologyQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestMethodologyDto>> Handle(GetTestMetholodogyQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();

            var finalData = _mapper.Map<List<TestMethodologyDto>>(data);

            return finalData;
        }
    }
}