using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuflitBigPrj.Models
{
    public class InvoiceType : FullAuditedEntity
    {
        [Key]
        [StringLength(2, ErrorMessage = "Maximum length is 2")]
        public string InvoiceTypeID { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string TypeName { get; set; }

        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
