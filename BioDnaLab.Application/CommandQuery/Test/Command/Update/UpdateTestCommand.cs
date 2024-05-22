using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Application.CommandQuery.Test.Command.Update
{
    public class UpdateTestCommand : IRequest<long>
    {
        public long Id { get; set; }
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
        public bool IsActive { get; set; } = true;
    }
}