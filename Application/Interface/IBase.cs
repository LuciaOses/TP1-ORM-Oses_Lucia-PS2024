using Retail.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Application.Interface
{
    public interface IBase<T>
    {
        T Create(T entity);
        T Remove(int id);
        T Update(T entity);
        List<T> GetAll();
        
    }
    /*public interface IProductService
    {
        Product CreateProduct(Product product);
        Product RemoveProduct(int productId);
        Product UpdateProduct(Product product);
        List<Product> GetProductList();
        Product GetProductById(int productId);
    }*/
}
