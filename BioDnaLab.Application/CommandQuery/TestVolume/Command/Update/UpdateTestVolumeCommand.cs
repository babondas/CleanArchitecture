using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Command.Update
{
    // IRequest<int> => what output we want
    public class UpdateTestVolumeCommand : IRequest<long>
    {
        public long Id { get; set; }
        public string TestVolumeName { get; set; }
        public string? Description { get; set; } = null;
        public bool IsActive { get; set; } = true;

    }
}
