﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("SuportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(50)]
        public string Department { set; get; }

        [Required]
        [MaxLength(50)]
        public string Skype { set; get; }

        [Required]
        [MaxLength(50)]
        public string Mobile { set; get; }

        [Required]
        [MaxLength(50)]
        public string Email { set; get; }

        [Required]
        [MaxLength(50)]
        public string Yahoo { set; get; }

        [Required]
        [MaxLength(50)]
        public string Facebook { set; get; }

        [Required]
        [MaxLength(50)]
        public string Status { set; get; }

        public int? DisplayOrder { set; get; }
    }
}
