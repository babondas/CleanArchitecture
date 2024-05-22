using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Update;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestMethodology;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Command.Update
{
    public class UpdateTestMetholodogyHandler : IRequestHandler<UpdateTestMetholodogyCommand, long>
    {
        private readonly ITestMethodologyCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestMetholodogyHandler(ITestMethodologyCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestMetholodogyCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestMethodologyEntity()
            {
                TestMethodologyName = request.TestMetholodogyName,
                Description = request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}
