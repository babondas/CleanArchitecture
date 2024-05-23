using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestStorage.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Command.Delete
{
    public class DeleteAccountHandler : IRequestHandler<DeleteAccountCommand, long>
    {
        private readonly IAccountRepositoryCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteAccountHandler(IAccountRepositoryCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}

