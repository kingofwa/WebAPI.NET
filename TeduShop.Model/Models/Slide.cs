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
    [Table("Slides")]
    class Slide :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Description { set; get; }

        public string Image { set; get; }

        public string URL { set; get; }

        public string DislayOrder { set; get; }
    
    }
}
