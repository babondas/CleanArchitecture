using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Query.Get
{
    public class GetAccountQuery : IRequest<List<AccountDto>>
    {
    }
}
