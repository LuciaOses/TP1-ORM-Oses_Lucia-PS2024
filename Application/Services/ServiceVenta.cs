using System;
using Retail.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retail.Application.Interface;

namespace Retail.Application.Services
{
    internal class ServiceVenta : IBase<SaleProduct>
    {
        public SaleProduct Create(SaleProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<SaleProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public SaleProduct GetById(int id)
        {
            throw new NotImplementedException();
        }

        public SaleProduct Remove(int id)
        {
            throw new NotImplementedException();
        }

        public SaleProduct Update(SaleProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}
