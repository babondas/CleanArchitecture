using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Command.Create
{
    public class CreateTestVolumeCommand : IRequest<long>
    {
        public string TestVolumeName { get; set; }
        public string? Description { get; set; } = null;
       
    }
}
