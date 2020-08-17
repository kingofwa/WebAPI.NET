using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstrack;

namespace TeduShop.Model.Models
{
    [Table("Oders")]
   public class Oder : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string CustommerName { set; get; }
        public string CustommerAddress { set; get; }
        public string CustommerEmail { set; get; }
        [Required]
        public string CustommerMobile { set; get; }
        public string CustommerMessage { set; get; }
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
     }
}
