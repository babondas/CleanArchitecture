using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestPackageWithTest.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Query.Get;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.TestPackageWithTest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Query.Get
{
    public class GetTestPackageWithTestHandler : IRequestHandler<GetTestPackageWithTestQuery, List<TestPackageWithTestEntityDto>>
    {
        //contrl .
        private readonly ITestPackageWithTestRepositoryQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestPackageWithTestHandler(ITestPackageWithTestRepositoryQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestPackageWithTestEntityDto>> Handle(GetTestPackageWithTestQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            //var testList = tests.Select(x => new TestDto 
            //{ 
            //    Author =x.Author, 
            //    Name = x.Name,
            //    Description= x.Description, 
            //    Id=x.Id
            //}).ToList();

            var finalData = _mapper.Map<List<TestPackageWithTestEntityDto>>(data);

            return finalData;
        }
    }
}
