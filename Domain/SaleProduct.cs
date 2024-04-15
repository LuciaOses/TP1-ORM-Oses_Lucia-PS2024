using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Domain
{
    public class SaleProduct
    {
        [Key]
        public int ShoppingCartId { get; set; }

        [Required]
        public int Sale { get; set; }

        [Required]
        public Guid Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Discount{ get; set; }

        //Relaciones Tabla
        public virtual Sale Venta { get; set; }
        public virtual Product Producto { get; set; }


}
}
