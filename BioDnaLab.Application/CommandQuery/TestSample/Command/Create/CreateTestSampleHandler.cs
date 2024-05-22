using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSample;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Command.Create
{
    public class CreateTestSampleHandler : IRequestHandler<CreateTestSampleCommand, long>
    {
        private readonly ITestSampleCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestSampleHandler(ITestSampleCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestSampleCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestSampleEntity()
            {
                TestSampleName = request.TestSampleName,
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