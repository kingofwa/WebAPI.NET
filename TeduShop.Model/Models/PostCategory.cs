﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstrack;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory :Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOder { set; get; }
        public bool? HomeFlag  { set; get; }
       
        public virtual IEnumerable<Post> Posts { set; get; }
    }
}
