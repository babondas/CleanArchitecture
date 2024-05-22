using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.Entity.TestPackage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackage.Command.Create
{
    public class CreateTestPackageHandler : IRequestHandler<CreateTestPackageCommand, long>
    {
        private readonly ITestPackageRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestPackageHandler(ITestPackageRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestPackageCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestPackageEntity()
            {
                TestPackageSecondName = request.TestPackageSecondName,
                RefTestPackageFirstNameId = request.RefTestPackageFirstNameId,
                MRP=request.MRP,
                OfferPrice=request.OfferPrice,
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
