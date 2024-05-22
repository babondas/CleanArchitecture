using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.ITestPackageFirstName;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Command.Create
{
    public class CreateTestPackageFirstNameHandler : IRequestHandler<CreateTestPackageFirstNameCommand, long>
    {
        private readonly ITestPackageFirstNameCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestPackageFirstNameHandler(ITestPackageFirstNameCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestPackageFirstNameCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestPackageFirstNameEntity()
            {
                TestPackageFirstName = request.TestPackageFirstName,
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
