using AutoMapper;
using BioDnaLab.Application.CommandQuery.Test.Dto;
using BioDnaLab.Application.CommandQuery.TestMethodology.Command.Create;
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

namespace BioDnaLab.Application.CommandQuery.Test.Command.Create
{
    public class CreateTestHandler : IRequestHandler<CreateTestCommand, long>
    {
        private readonly ITestRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestHandler(ITestRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestEntity()
            {
                TestName = request.TestName,
                Description = request.Description,
                RefTestMethodologyId=request.RefTestMethodologyId,
                RefTestSampleId = request.RefTestSampleId,
                RefTestVolumeId = request.RefTestVolumeId,
                RefTestStorageId = request.RefTestStorageId,
                RefTestScheduleId = request.RefTestScheduleId,
                RefTestReportId = request.RefTestReportId,
                MRP = request.MRP,
                TestPriceDiscount = request.TestPriceDiscount,
                TestPriceDiscountInPercent = request.TestPriceDiscountInPercent,
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