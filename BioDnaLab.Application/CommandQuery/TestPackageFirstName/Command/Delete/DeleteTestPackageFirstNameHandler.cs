using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.ITestPackageFirstName;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Command.Delete
{
    public class DeleteTestPackageFirstNameHandler : IRequestHandler<DeleteTestPackageFirstNameCommand, long>
    {
        private readonly ITestPackageFirstNameCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteTestPackageFirstNameHandler(ITestPackageFirstNameCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<long> Handle(DeleteTestPackageFirstNameCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}
