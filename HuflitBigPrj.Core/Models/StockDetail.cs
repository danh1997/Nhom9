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
    public class StockDetail : FullAuditedEntity
    {
        [Required]
        [ForeignKey("Inventory")]
        public int InvtID { get; set; }
        public virtual Inventory Inventory { get; set; }

        [Required]
        [ForeignKey("Stock")]
        public int StockNo { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
