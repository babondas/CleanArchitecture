using AutoMapper;
using BioDnaLab.Application.CommandQuery.Test.Dto;
using BioDnaLab.Application.CommandQuery.TestMethodology.Dto;
using BioDnaLab.Application.CommandQuery.TestMethodology.Query.Get;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestMethodology;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Query.Get
{
    public class GetTestHandler : IRequestHandler<GetTestQuery, List<TestDto>>
    {
        //contrl .
        private readonly ITestRepositoryQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestHandler(ITestRepositoryQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestDto>> Handle(GetTestQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();

            var finalData = _mapper.Map<List<TestDto>>(data);

            return finalData;
        }
    }
}
