using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuflitBigPrj.Models
{
    public class Customer : FullAuditedentity
    {
        [Key]
        public int CustID { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string CustName { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string Address { get; set; }

        [StringLength(20, ErrorMessage = "Maximum length is 20")]
        public string Phone { get; set; }

        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string Email { get; set; }

        [StringLength(2, ErrorMessage = "Maximum length is 2")]
        public string Status { get; set; }

        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
