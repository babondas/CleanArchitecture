using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Command.Update
{
    //IRequestHandler<UpdateTestCommand, int>  => IRequestHandler<request, return>
    public class UpdateTestVolumeHandler : IRequestHandler<UpdateTestVolumeCommand, long>
    {
        private readonly ITestVolumeCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestVolumeHandler(ITestVolumeCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestVolumeCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestVolumeEntity()
            {
                TestVolumeName = request.TestVolumeName,
                Description = request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}
