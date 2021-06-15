using Demo_MVC_NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_MVC_NetCore
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
