using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Command.Create
{
    public class CreateTestVolumeHandler : IRequestHandler<CreateTestVolumeCommand, long>
    {
        private readonly ITestVolumeCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestVolumeHandler(ITestVolumeCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestVolumeCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestVolumeEntity()
            {
                TestVolumeName = request.TestVolumeName,
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
