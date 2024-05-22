using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestReport;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestReport.Command.Delete
{
    public class DeleteTestReportHandler : IRequestHandler<DeleteTestReportCommand, long>
    {
        private readonly ITestReportCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteTestReportHandler(ITestReportCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ITestReportCommand Get_repository()
        {
            return _repository;
        }

        public async Task<long> Handle(DeleteTestReportCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}
