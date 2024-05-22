using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestPackage.Command.Create;
using BioDnaLab.Application.CommandQuery.TestPackageWithTest.Dto;
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

namespace BioDnaLab.Application.CommandQuery.TestPackageWithTest.Command.Create
{
    public class CreateTestPackageWithTestHandler : IRequestHandler<CreateTestPackageWithTestCommand, long>
    {
        private readonly ITestPackageWithTestRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestPackageWithTestHandler(ITestPackageWithTestRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestPackageWithTestCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestPackageWithTestEntity()
            {
                RefTestId = request.RefTestId,
                RefTestPackageId = request.RefTestPackageId,
                Description = request.Description,
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                CreatedBy = 1,
                ModifiedBy = null,
                IsActive = true
            };

            var result = await _repository.AddAsync(entity);
            return _mapper.Map<long>(result.Id);
        }
    }
}
