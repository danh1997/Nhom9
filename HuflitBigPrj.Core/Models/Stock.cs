using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuflitBigPrj.Models
{
    public class Stock : FullAuditedEntity
    {
        [Key]
        public int StockNo { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string StockName { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string Address { get; set; }

        public virtual ICollection<StockDetail> StockDetails { get; set; }
        public virtual ICollection<StockTransfer> StockTransfers { get; set; }
        public virtual CheckStock CheckStock { get; set; }

    }
}
