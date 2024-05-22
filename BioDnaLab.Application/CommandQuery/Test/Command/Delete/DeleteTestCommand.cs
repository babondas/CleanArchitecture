using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Command.Delete
{
    public class DeleteTestCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}