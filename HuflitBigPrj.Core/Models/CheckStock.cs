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
    public class CheckStock : FullAuditedEntity
    {
        [Key]
        public int CheckNo { get; set; }
        
        public DateTime CheckDate { get; set; }

        [StringLength(200, ErrorMessage = "Maximum length is 200")]
        public string Description { get; set; }

        [Required]
        [ForeignKey("Stocks")]
        public int StockNo { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
