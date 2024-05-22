using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Account.Query.GetByEmailAndPassword
{
    public class GetAccountByEmailAndPasswordQuery : IRequest<AccountDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
