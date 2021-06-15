using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_MVC_NetCore.Models;
using Dapper;

namespace Demo_MVC_NetCore
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }


        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("Select * from Products;");
        }
    }
}
