using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSample;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Command.Delete
{
    public class DeleeTestSampleHandler : IRequestHandler<DeleeTestSampleCommand, long>
    {
        private readonly ITestSampleCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleeTestSampleHandler(ITestSampleCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<long> Handle(DeleeTestSampleCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}