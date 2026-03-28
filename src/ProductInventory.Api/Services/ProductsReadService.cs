using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductInventory.Api.Services
{
    public class ProductsReadService
    {
        public ProductsReadService(){}

        public List<String> FindAll()
        {
            return new List<String> { "Ana", "Bruno", "Carla", "Daniel" };
        }
    }
}