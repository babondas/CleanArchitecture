using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestPackageFirstName.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Query.Get;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.ITestPackageFirstName;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Query.Get
{
    public class GetTestPackageFirstNameHandler : IRequestHandler<GetTestPackageFirstNameQuery, List<TestPackageFirstNameEntityDto>>
    {
        //contrl .
        private readonly ITestPackageFirstNameNameQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestPackageFirstNameHandler(ITestPackageFirstNameNameQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestPackageFirstNameEntityDto>> Handle(GetTestPackageFirstNameQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            //var testList = tests.Select(x => new TestDto 
            //{ 
            //    Author =x.Author, 
            //    Name = x.Name,
            //    Description= x.Description, 
            //    Id=x.Id
            //}).ToList();

            var finalData = _mapper.Map<List<TestPackageFirstNameEntityDto>>(data);

            return finalData;
        }
    }
}
