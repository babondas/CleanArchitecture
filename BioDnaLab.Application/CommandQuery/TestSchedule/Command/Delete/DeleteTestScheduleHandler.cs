using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestStorage.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestSchedule;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestSchedule.Command.Delete
{
    public class DeleteTestScheduleHandler : IRequestHandler<DeleteTestScheduleCommand, long>
    {
        private readonly ITestScheduleCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteTestScheduleHandler(ITestScheduleCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(DeleteTestScheduleCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}

