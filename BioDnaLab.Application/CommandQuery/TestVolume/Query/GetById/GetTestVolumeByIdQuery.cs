using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.Account.Query.GetById
{
    public class GetTestVolumeByIdQuery : IRequest<TestVolumeDto>
    {
        public long Id { get; set; }
    }
}
