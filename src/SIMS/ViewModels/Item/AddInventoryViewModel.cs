﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIMS.ViewModels.Item
{
    public class AddInventoryViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int EndangeredQuantity { get; set; }
        [Required]
        public int Expected { get; set; }
        [Required]
        public int Actual { get; set; }
        [Required]
        public int Promised { get; set; }
    }
}
