using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestMethodology.Dto;
using BioDnaLab.Domain.IRepository.IRepositoryQuery.ITest.ITestMethodology;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Query.GetById
{
    public class GetTestMetholodogyByIdHandler : IRequestHandler<GetTestMetholodogyByIdQuery, TestMethodologyDto>
    {
        private readonly ITestMethodologyQuery _repository;
        private readonly IMapper _mapper;

        //ctor
        public GetTestMetholodogyByIdHandler(ITestMethodologyQuery repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TestMethodologyDto> Handle(GetTestMetholodogyByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TestMethodologyDto>(data);
        }
    }
}