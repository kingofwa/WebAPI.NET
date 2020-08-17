using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstrack;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
   public class Order //: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string CustommerName { set; get; }
        [MaxLength(256)]
        public string CustommerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustommerEmail { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustommerMobile { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustommerMessage { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
     }
}
