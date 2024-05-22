using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestStorage.Command.Create
{
    public class CreateTestStorageCommand : IRequest<long>
    {
        public string TestStorageName { get; set; }
        public string? Description { get; set; } = null;
        
    }
}
