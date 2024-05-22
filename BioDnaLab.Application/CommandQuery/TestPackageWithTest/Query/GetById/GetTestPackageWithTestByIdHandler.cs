using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestPackageWithTest.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.TestPackageWithTest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Query.GetById
{
    public class GetTestPackageWithTestByIdHandler : IRequestHandler<GetTestPackageWithTestByIdQuery, TestPackageWithTestEntityDto>
    {
        private readonly ITestPackageWithTestRepositoryQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestPackageWithTestByIdHandler(ITestPackageWithTestRepositoryQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestPackageWithTestEntityDto> Handle(GetTestPackageWithTestByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestPackageWithTestEntityDto>(data);
        }
    }
}

