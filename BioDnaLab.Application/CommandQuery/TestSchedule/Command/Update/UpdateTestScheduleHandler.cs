using AutoMapper;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSchedule;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Command.Update
{
    public class UpdateTestScheduleHandler : IRequestHandler<UpdateTestScheduleCommand, long>
    {
        private readonly ITestScheduleCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestScheduleHandler(ITestScheduleCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestScheduleCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestScheduleEntity()
            {
                TestScheduleName = request.TestScheduleName,
                Description = request.Description,
                ModifiedDate = request.ModifiedDate,
                ModifiedBy = request.ModifiedBy,
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}
