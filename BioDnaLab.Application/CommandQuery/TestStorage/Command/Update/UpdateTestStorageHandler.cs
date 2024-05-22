using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Update;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestStorage.Command.Update
{
    public class UpdateTestStorageHandler : IRequestHandler<UpdateTestStorageCommand, long>
    {
        private readonly ITestStorageCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestStorageHandler(ITestStorageCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestStorageCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestStorageEntity()
            {
                TestStorageName = request.TestStorageName,
                Description = request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}

