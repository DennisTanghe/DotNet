using DT.DotNet.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.Repository
{
    public class ProductRepository
    {

        public Product Retrieve(int id)
        {
            var product = new Product(id)
            {
                CurrentPrice = 15.78M,
                Description = "This is my long product description",
                Name = "The Name"
            };

            return product;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save(Product product)
        {
            bool success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // create the product

                    }
                    else
                    {
                        // Update the product
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
