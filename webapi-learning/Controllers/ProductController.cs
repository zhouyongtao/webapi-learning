using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi_learning.Filters;
using webapi_learning.Models;


namespace webapi_learning.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        /// <summary>
        /// 活动所有产品信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        /// <summary>
        /// 获得一个产品
        /// </summary>
        /// <param name="id">产品编号</param>
        /// <returns></returns>
        [AsyncLoggingFilter]
        public Product GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }


        public Product PostProduct(Product item)
        {
            //item = repository.Add(item);
            return null;
        }


        /// <summary>
        /// Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        [HttpPut]
        public void PutProduct(int id, Product product)
        {
            product.Id = id;
            if (true)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        /// <summary>
        /// Deleting 
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        public void DeleteProduct(int id)
        {
            //repository.Remove(id);
        }

    }
}
