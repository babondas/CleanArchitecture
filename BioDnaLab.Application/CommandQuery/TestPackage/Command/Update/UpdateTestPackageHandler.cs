using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Update;
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

namespace BioDnaLab.Application.CommandQuery.TestPackage.Command.Update
{
    public class UpdateTestPackageHandler : IRequestHandler<UpdateTestPackageCommand, long>
    {
        private readonly ITestPackageRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestPackageHandler(ITestPackageRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestPackageCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestPackageEntity()
            {
                RefTestPackageFirstNameId = request.RefTestPackageFirstNameId,
                TestPackageSecondName = request.TestPackageSecondName,
                MRP = request.MRP,
                OfferPrice = request.OfferPrice,
                Description = request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1
    };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}

