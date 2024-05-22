using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestPackage.Command.Update;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.Entity.TestPackage.JunctionTable;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.TestPackageWithTest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Command.Update
{
    public class UpdateTestPackageWithTestHandler : IRequestHandler<UpdateTestPackageWithTestCommand, long>
    {
        private readonly ITestPackageWithTestRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestPackageWithTestHandler(ITestPackageWithTestRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestPackageWithTestCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestPackageWithTestEntity()
            {
                RefTestId = request.RefTestId,
                RefTestPackageId = request.RefTestPackageId,
                Description = request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}
