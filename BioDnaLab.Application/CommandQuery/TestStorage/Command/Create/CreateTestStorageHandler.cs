using AutoMapper;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using BioDnaLab.Domain.Entity.Test.TestSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestStorage;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITest.ITestVolume;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestStorage.Command.Create
{
    public class CreateTestStorageHandler : IRequestHandler<CreateTestStorageCommand, long>
    {
        private readonly ITestStorageCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public CreateTestStorageHandler(ITestStorageCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateTestStorageCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestStorageEntity()
            {
                TestStorageName = request.TestStorageName,
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
