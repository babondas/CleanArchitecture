using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestStorage.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Application.CommandQuery.TestVolume.Query.Get;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestStorage;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestStorage.Query.Get
{
    public class GetTestStorageHandler : IRequestHandler<GetTestStorageQuery, List<TestStorageDto>>
    {
        //contrl .
        private readonly ITestStorageQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestStorageHandler(ITestStorageQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<TestStorageDto>> Handle(GetTestStorageQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();

            var finalData = _mapper.Map<List<TestStorageDto>>(data);

            return finalData;
        }
    }
}

