using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.TestPackage.Command.Create
{
    public class CreateTestPackageCommand : IRequest<long>
    {
        public int? RefTestPackageFirstNameId { get; set; }
        public string? TestPackageSecondName { get; set; }
        public string? Description { get; set; }
        public decimal? MRP { get; set; } = 0.00m;
        public decimal? OfferPrice { get; set; } = 0.00m;
    }
}
