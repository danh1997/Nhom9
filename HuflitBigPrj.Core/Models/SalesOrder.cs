using Abp.Domain.Entities.Auditing;
using HuflitBigPrj.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuflitBigPrj.Models
{
    public class SalesOrder : FullAuditedEntity
    {
        [Key]
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReDate { get; set; }
        public decimal SumTaxAmt { get; set; }
        public decimal TotalAmt { get; set; }
        public decimal SumPayment { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustID { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<SalesOrderDetail> Sales { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Maximum length is 2")]
        [ForeignKey("Type")]
        public string InvoiceType { get; set; }
        public virtual InvoiceType Type { get; set; }

        [Required]
        [ForeignKey("User")]
        public long UserID { get; set; }
        public virtual User User { get; set; }
    }
}
