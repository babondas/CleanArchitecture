using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestPackageFirstName.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITestPackage.ITestPackageFirstName;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Query.GetById
{
    public class GetTestPackageFirstNameByIdHandler : IRequestHandler<GetTestPackageFirstNameByIdQuery, TestPackageFirstNameEntityDto>
    {
        private readonly ITestPackageFirstNameNameQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestPackageFirstNameByIdHandler(ITestPackageFirstNameNameQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestPackageFirstNameEntityDto> Handle(GetTestPackageFirstNameByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestPackageFirstNameEntityDto>(data);
        }
    }
}