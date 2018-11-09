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
    public class Payment : FullAuditedEntity
    {
        [Key]
        [Required]
        public int PaymentID { get; set; }

        [StringLength(20, ErrorMessage = "Maximum length is 20")]
        public string PaymentNo { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmt { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustID { get; set; }
        public virtual Customer Customer { get; set; }
        
        [Required]
        [ForeignKey("User")]
        public long UserID { get; set; }
        public virtual User User  { get; set; }
    }
}
