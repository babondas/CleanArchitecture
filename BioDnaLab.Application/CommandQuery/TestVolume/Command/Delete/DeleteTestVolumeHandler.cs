using AutoMapper;
using BioDnaLab.Application.CommandQuery.Account.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete
{
    public class DeleteTestVolumeHandler : IRequestHandler<DeleteTestVolumeCommand, long>
    {
        private readonly ITestVolumeCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteTestVolumeHandler(ITestVolumeCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ITestVolumeCommand Get_repository()
        {
            return _repository;
        }

        public async Task<long> Handle(DeleteTestVolumeCommand request, CancellationToken cancellationToken)
        {
            var itm= await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}
