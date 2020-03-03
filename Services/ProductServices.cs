using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Domain.Models;

namespace WebApi.Services
{
    public class ProductServices
    {

        List<Product> product = new List<Product>();
        //    {
        //        new Product() {,Name = "abc",CategoryId = 320}
        //};
        
        public void abc(string Name)
        {

            product.Add(new Product { Name = Name });

            //Console.WriteLine(product);
            //var w = new Product() { Name = Name};

            //JsonSerializer.Serialize<Product>(w);
        }

       
    }

}

