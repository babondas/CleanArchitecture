using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestMethodology.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestMethodology;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Command.Delete
{
    public class DeleteTestHandler : IRequestHandler<DeleteTestCommand, long>
    {
        private readonly ITestRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteTestHandler(ITestRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<long> Handle(DeleteTestCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}