using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Domain.Models
{
   
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Context { get; set; }
            public int Price { get; set; }
            public int new_Price { get; set; }
            public int CategoryId { get; set; }
            public Category Category { get; set; }

    }
}
