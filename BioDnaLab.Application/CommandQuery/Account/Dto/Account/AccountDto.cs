using BioDnaLab.Application.Common.Mappings;
using BioDnaLab.Domain.Entity.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Account.Dto.Account
{
    public class AccountDto : RegisterDto, IMapFrom<AccountEntity>
    {
        public long Id { get; set; }
    }
}
