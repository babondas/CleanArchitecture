using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackage.Command.Delete
{
    public class DeleteTestPackageHandler : IRequestHandler<DeleteTestPackageCommand, long>
    {
        private readonly ITestPackageRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteTestPackageHandler(ITestPackageRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(DeleteTestPackageCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}

