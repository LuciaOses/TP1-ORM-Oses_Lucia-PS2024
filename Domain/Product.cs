using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public virtual ICollection<SaleProduct> VentaProductos { get; set; }

        public virtual Category Categoria { get; set; } // Propiedad de navegación a la categoría

        
    }
}
