using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestMethodology;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestMethodology.Command.Delete
{
    public class DeleteTestMetholodogyHandler : IRequestHandler<DeleteTestMetholodogyCommand, long>
    {
        private readonly ITestMethodologyCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public DeleteTestMetholodogyHandler(ITestMethodologyCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<long> Handle(DeleteTestMetholodogyCommand request, CancellationToken cancellationToken)
        {
            var itm = await _repository.DeleteAsync(request.Id);
            return itm.Id;
        }
    }
}