using DT.DotNet.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DT.DotNet.Repository.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange

            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                LastName = "Baggins",
                FirstName = "Frodo",
                EmailAddress = "frodo@baggins.com"
            };

            // Actual

            var actual = customerRepository.Retrieve(1);

            // Assert

            Assert.AreEqual(expected.CustormerId, actual.CustormerId);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // Arrange

            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                LastName = "Baggins",
                FirstName = "Frodo",
                EmailAddress = "frodo@baggins.com",
                Addresses = new List<Address>()
                {
                    new Address(1)
                    {
                        StreetLine1 = "Street line 1",
                        StreetLine2 = "Street line 2",
                        PostalCode = "1234",
                        City = "The City",
                        StateProvince = "The Province",
                        Country = "The Country",
                        Type = "Home"
                    },
                    new Address(2)
                    {
                        StreetLine1 = "Street line 1",
                        StreetLine2 = "Street line 2",
                        PostalCode = "1234",
                        City = "The City",
                        StateProvince = "The Province",
                        Country = "The Country",
                        Type = "Work"
                    }
                }
            };

            // Actual

            var actual = customerRepository.Retrieve(1);

            // Assert

            Assert.AreEqual(expected.CustormerId, actual.CustormerId);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for(var i = 0; i < expected.Addresses.Count; i++)
            {
                Assert.AreEqual(expected.Addresses[i].StreetLine1, actual.Addresses[i].StreetLine1);
                Assert.AreEqual(expected.Addresses[i].StreetLine2, actual.Addresses[i].StreetLine2);
                Assert.AreEqual(expected.Addresses[i].City, actual.Addresses[i].City);
                Assert.AreEqual(expected.Addresses[i].PostalCode, actual.Addresses[i].PostalCode);
                Assert.AreEqual(expected.Addresses[i].Country, actual.Addresses[i].Country);
            }
        }
    }
}
