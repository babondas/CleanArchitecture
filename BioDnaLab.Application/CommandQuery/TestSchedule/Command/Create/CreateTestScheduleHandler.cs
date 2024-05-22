using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestStorage.Command.Create;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSchedule;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Command.Create
{
    public class CreateTestScheduleHandler : IRequestHandler<CreateTestScheduleCommand, long>
    {
        private readonly ITestScheduleCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestScheduleHandler(ITestScheduleCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestScheduleCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestScheduleEntity()
            {
                TestScheduleName = request.TestScheduleName,
                Description = request.Description,
                CreatedDate = request.CreatedDate,
                ModifiedDate = request.ModifiedDate,
                CreatedBy = request.CreatedBy,
                ModifiedBy = request.ModifiedBy,
                IsActive = request.IsActive
            };

            var result = await _repository.AddAsync(entity);
            return _mapper.Map<long>(result.Id);
        }
    }
}
