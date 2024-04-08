using Microsoft.EntityFrameworkCore;
using Retail.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Retail.Infrastructure
{
    public class RetailContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LUCY\\MSSQLSERVER01;Initial Catalog=Retail;Integrated Security=True;Pooling=False;TrustServerCertificate=True");
        }

        //Agregar tablas a BD
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Sale> Sale { get; set; }

        public DbSet<SaleProduct> SaleProduct { get; set; }
    }
}
