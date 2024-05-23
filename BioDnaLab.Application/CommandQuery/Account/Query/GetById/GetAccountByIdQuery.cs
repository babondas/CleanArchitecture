using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Query.GetById
{
    public class GetAccountByIdQuery : IRequest<AccountDto>
    {
        public long AccountId { get; set; }
    }
}
