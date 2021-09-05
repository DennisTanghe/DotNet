using DT.DotNet.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.Repository.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange

            var productRepository = new ProductRepository();

            var expected = new Product(1)
            {
                CurrentPrice = 15.78M,
                Description = "This is my long product description",
                Name = "The Name"
            };

            // Actual

            var actual = productRepository.Retrieve(1);

            // Assert

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.Name, actual.Name);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange

            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                CurrentPrice = 15.78M,
                Description = "This is my long product description",
                Name = "The Name",
                HasChanges = true
            };

            // Actual

            var actual = productRepository.Save(updatedProduct);

            // Assert

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange

            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "This is my long product description",
                Name = "The Name",
                HasChanges = true
            };

            // Actual

            var actual = productRepository.Save(updatedProduct);

            // Assert

            Assert.AreEqual(false, actual);
        }
    }
}
