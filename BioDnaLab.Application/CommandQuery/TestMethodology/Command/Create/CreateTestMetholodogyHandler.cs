using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestMethodology;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Command.Create
{
    public class CreateTestMetholodogyHandler : IRequestHandler<CreateTestMetholodogyCommand, long>
    {
        private readonly ITestMethodologyCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestMetholodogyHandler(ITestMethodologyCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestMetholodogyCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestMethodologyEntity()
            {
                TestMethodologyName = request.TestMetholodogyName,
                Description = request.Description,
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                CreatedBy = 1,
                ModifiedBy = null,
                IsActive = true
            };

            var result = await _repository.AddAsync(entity);
            return _mapper.Map<long>(result.Id);
        }
    }
}