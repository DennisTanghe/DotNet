using DT.DotNet.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.Common.Test
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer()
            {
                LastName = "Baggins",
                FirstName = "Bilbo"
            };

            changedItems.Add(customer);

            var product = new Product(1)
            {
                CurrentPrice = 15.78M,
                Description = "This is my long product description",
                Name = "The Name"
            };

            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);

            // check output
        }
    }
}
