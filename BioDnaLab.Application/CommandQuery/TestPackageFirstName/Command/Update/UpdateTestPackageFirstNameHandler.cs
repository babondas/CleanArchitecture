using AutoMapper;
using BioDnaLab.Domain.Entity.TestPackage.TestPackageSubEntities;
using BioDnaLab.Domain.IRepository.IRepositoryCommand.ITestPackage.ITestPackageFirstName;
using MediatR;

namespace BioDnaLab.Application.CommandQuery.TestPackageFirstName.Command.Update
{
    public class UpdateTestPackageFirstNameHandler : IRequestHandler<UpdateTestPackageFirstNameCommand, long>
    {
        private readonly ITestPackageFirstNameCommand _repository;
        private readonly IMapper _mapper;

        //ctor
        public UpdateTestPackageFirstNameHandler(ITestPackageFirstNameCommand repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<long> Handle(UpdateTestPackageFirstNameCommand request, CancellationToken cancellationToken)
        {
            var entity = new TestPackageFirstNameEntity()
            {
                TestPackageFirstName = request.TestPackageFirstName,
                Description = request.Description,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
            };

            var itm = await _repository.UpdateAsync(request.Id, entity);
            return itm.Id;
        }
    }
}