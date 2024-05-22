using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete
{
    public class DeleteTestVolumeCommand : IRequest<long>
    {
        public long Id { get; set; }
    }
}
