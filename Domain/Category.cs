﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Domain
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        //Relaciones Tabla
        [Required]
        public ICollection<Product> Productos { get; set; } = new List<Product>();
    }
}
