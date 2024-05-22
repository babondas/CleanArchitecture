using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestPackage.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.TestPackageWithTest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Command.Delete
{
    public class DeleteTestPackageWithTestHandler : IRequestHandler<DeleteTestPackageWithTestCommand, long>
    {
        private readonly ITestPackageWithTestRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteTestPackageWithTestHandler(ITestPackageWithTestRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(DeleteTestPackageWithTestCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}
