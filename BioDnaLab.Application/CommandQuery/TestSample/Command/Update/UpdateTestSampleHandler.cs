using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Update;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSample;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSample.Command.Update
{
    public class UpdateTestSampleHandler : IRequestHandler<UpdateTestSampleCommand, long>
    {
        private readonly ITestSampleCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestSampleHandler(ITestSampleCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestSampleCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestSampleEntity()
            {
                TestSampleName = request.TestSampleName,
                Description = request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}
