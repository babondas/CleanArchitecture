using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.Entity.Base
{
    public class BaseEntity
    {
        //public BaseEntity()
        //{
        //    CreatedDate = DateTime.Now;
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get;  set; }
        public long CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

    }
}
