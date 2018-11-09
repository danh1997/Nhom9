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
    public class StockTransDetail :FullAuditedEntity
    {
        [Required]
        [ForeignKey("StockTransfer")]
        public int TransID { get; set; }

        public int Qty { get; set; }
        public decimal Amount { get; set; }

        public virtual StockTransfer StockTransfer { get; set; }

        [Required]
        [ForeignKey("Inventory")]
        public int InvtID { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
