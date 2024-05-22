using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestMethodology.Command.Update;
using BioDnaLab.Domain.Entity.Test;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestMethodology;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Command.Update
{
    public class UpdateTestHandler : IRequestHandler<UpdateTestCommand, long>
    {
        private readonly ITestRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestHandler(ITestRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestEntity()
            {
                TestName = request.TestName,
                Description = request.Description,
                RefTestMethodologyId = request.RefTestMethodologyId,
                RefTestSampleId = request.RefTestSampleId,
                RefTestVolumeId = request.RefTestVolumeId,
                RefTestStorageId = request.RefTestStorageId,
                RefTestScheduleId = request.RefTestScheduleId,
                RefTestReportId = request.RefTestReportId,
                MRP = request.MRP,
                TestPriceDiscount = request.TestPriceDiscount,
                TestPriceDiscountInPercent = request.TestPriceDiscountInPercent,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}
