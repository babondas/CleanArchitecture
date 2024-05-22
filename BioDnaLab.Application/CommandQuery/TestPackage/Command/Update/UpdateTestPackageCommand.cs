using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackage.Command.Update
{
    public class UpdateTestPackageCommand : IRequest<long>
    {
        public long Id { get; set; }
        public int? RefTestPackageFirstNameId { get; set; }
        public string? TestPackageSecondName { get; set; }
        public string? Description { get; set; }
        public decimal? MRP { get; set; } = 0.00m;
        public decimal? OfferPrice { get; set; } = 0.00m;
    }
}
