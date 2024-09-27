﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CmkCable.Entities
{
    public class Standart
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required.")]
        [StringLength(150)]
        public string Name { get; set; }
        public ICollection<ProductStandart> ProductStandarts { get; set; }
        public ICollection<StandartCertificate> StandartCertificates { get; set; }

    }
}