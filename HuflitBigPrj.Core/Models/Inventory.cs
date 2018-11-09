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
    public class Inventory : FullAuditedEntity
    {
        [Key]
        public int InvtID { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string InvtName { get; set; }
        public int QtyStock { get; set; }

        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        public virtual ICollection<StockDetail> StockDetails { get; set; }
        public virtual ICollection<StockTransDetail> StockTransDetails { get; set; }
    }
}
