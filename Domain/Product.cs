using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Retail.Domain
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Category { get; set; }

        [Required]
        public int Discount { get; set; }

        [Required, StringLength(255)]
        public string ImageUrl { get; set; } = string.Empty;

        //Relaciones Tabla
        [Required]
        public ICollection<SaleProduct> VentaProductos { get; set; } = new List<SaleProduct>();
        public Category Categoria { get; set; } = new Category();
    }
}
