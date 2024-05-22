using BioDnaLab.Application.CommandQuery.TestVolume.Dto;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestVolume.Query.Get
{
    public class GetTestVolumeQuery : IRequest<List<TestVolumeDto>>
    {
    }
}
