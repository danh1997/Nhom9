using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuflitBigPrj.Models
{
    public class StockTransfer : FullAuditedEntity
    {
        [Key]
        public int TransID { get; set; }
        public int TransDate { get; set; }
        
        public decimal TotalAmt { get; set; }

        [ForeignKey("FrmStock")]
        public int? FromStockID { get; set; }
        public virtual Stock FrmStock { get; set; }

        [ForeignKey("ToStock")]
        public int? ToStockID { get; set; }
        public virtual Stock ToStock { get; set; }

        public virtual ICollection<StockTransDetail> StockTransDetails { get; set; }
    }
}
