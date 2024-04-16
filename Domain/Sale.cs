using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Retail.Domain
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        public decimal TotalPlay { get; set; }

        [Required]
        public decimal SubTotal { get; set; }

        [Required]
        public decimal TotalDiscount { get; set; }

        [Required]
        public decimal Taxes { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        // Relaciones Tablas
        public virtual ICollection<SaleProduct>? VentaProductos { get; set; }
    }
}
