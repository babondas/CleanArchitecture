using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Command.Create
{
    public class CreateTestCommand : IRequest<long>
    {
        public string TestName { get; set; }
        public string? Description { get; set; } = null;
        public int? RefTestMethodologyId { get; set; } = null;
        public int? RefTestSampleId { get; set; } = null;
        public int? RefTestVolumeId { get; set; } = null;
        public int? RefTestStorageId { get; set; } = null;
        public int? RefTestScheduleId { get; set; } = null;
        public int? RefTestReportId { get; set; } = null;
        public decimal MRP { get; set; }
        public decimal? TestPriceDiscount { get; set; } = null;
        public int? TestPriceDiscountInPercent { get; set; } = null;
       
    }
}

