using AutoMapper;
using BioDnaLab.Domain.Entity.Account;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.IAccount;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Command.Update
{
    //IRequestHandler<UpdateTestCommand, int>  => IRequestHandler<request, return>
    //public class UpdateTestVolumeHandler : IRequestHandler<UpdateAccountCommand, long>
    //{
    //    private readonly IAccountRepositoryCommand _repository;
    //    private readonly IMapper _mapper;

    //    //ctor
    //    public UpdateTestVolumeHandler(IAccountRepositoryCommand repository, IMapper mapper)
    //    {
    //        _repository = repository;
    //        _mapper = mapper;
    //    }
    //    public async Task<long> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    //    {
    //        var entity = new AccountEntity()
    //        {
    //            Id = request.Id,
    //            Name = request.Name,
    //            Email = request.Email,
    //            PrimaryContactNumber = request.PrimaryContactNumber,
    //            SecondaryContactNumber = request.SecondaryContactNumber,
    //            Address = request.Address,
    //            Description = request.Description,
    //            CreatedDate = request.CreatedDate,
    //            ModifiedDate = request.ModifiedDate,
    //            CreatedBy = request.CreatedBy,
    //            ModifiedBy = request.ModifiedBy,
    //            IsActive = request.IsActive
    //        };

    //        AccountEntity accountEntity = await _repository.UpdateAsync(request.Id, entity);
    //        return accountEntity.Id;
    //    }
    //}
}
