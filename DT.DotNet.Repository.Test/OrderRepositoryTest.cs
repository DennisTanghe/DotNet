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
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange

            var orderRepository = new OrderRepository();

            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(2021, 9, 5, 18, 45, 00, new TimeSpan(1, 0, 0))
            };

            // Actual

            var actual = orderRepository.Retrieve(1);

            // Assert

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
