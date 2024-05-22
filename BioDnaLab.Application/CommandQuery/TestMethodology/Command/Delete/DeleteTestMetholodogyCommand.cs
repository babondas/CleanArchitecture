using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Command.Delete
{
    public class DeleteTestMetholodogyCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}

