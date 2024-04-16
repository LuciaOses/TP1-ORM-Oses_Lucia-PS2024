using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Retail.Application.Interface;
using Retail.Domain;
using Retail.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Application.Services
{
    public class ServiceProducto : IBase<Product>
    {
        private readonly RetailContext _context;

        public ServiceProducto (RetailContext context)
        {
            _context = context;
        }


        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            var getProductosList = _context.Product.ToList();
            return getProductosList;
        }

        public Product GetById(Guid productId)
        {
            var getProductById = _context.Product.Single(x => x.ProductId == productId);
            return getProductById;
        }
    

        public Product Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }

        /*public void ListaProductos()
        {
            using (var pro = new RetailContext())
                List<Product> productos = (from p in pro.Product where p.Price > 0 select p).OrderBy(p => p.Name).ToList();
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay ejemplares para alquilar.");
                return;
            }
            foreach (var libro in libros)
            {
                Console.WriteLine("Titulo: " + libro.Titulo + " " + "Autor: " + libro.Autor + " " + "ISBN: " + " " + libro.ISBN);
            }*/
        }
}



