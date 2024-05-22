using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Account.Command.Update
{
    // IRequest<int> => what output we want
    public class UpdateAccountCommand : IRequest<int>
    {
        //basically what we get from the ui
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PrimaryContactNumber { get; set; } = string.Empty;
        public string SecondaryContactNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public long CreatedBy { get; set; }
        public long ModifiedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
