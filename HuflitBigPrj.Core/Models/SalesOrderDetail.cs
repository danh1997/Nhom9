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
    public class SalesOrderDetail : FullAuditedEntity
    {
        public int Qty { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmtCust { get; set; }

        [Required]
        [ForeignKey("SalesOrder")]
        public int OrderNo { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }

        [ForeignKey("Inventory")]
        public int InvtID { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
