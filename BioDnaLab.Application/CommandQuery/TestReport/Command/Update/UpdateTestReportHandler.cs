using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Update;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestReport;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestReport.Command.Update
{
    public class UpdateTestReportHandler : IRequestHandler<UpdateTestReportCommand, long>
    {
        private readonly ITestReportCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestReportHandler(ITestReportCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestReportCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestReportEntity()
            {
                TestReportName = request.TestReportName,
                Description = request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}
