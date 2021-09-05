using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DT.DotNet.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            customer.FirstName = "Bilbo";

            string expected = "Baggins, Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";

            string expected = "Baggins";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            Customer c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCounter += 1;

            Customer c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCounter += 1;

            Customer c3 = new Customer();
            c3.FirstName = "Sam";
            Customer.InstanceCounter += 1;

            // Act
            int totalInstances = 3;

            // Assert
            Assert.AreEqual(totalInstances, Customer.InstanceCounter);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Customer c1 = new Customer();
            c1.LastName = "Baggins";
            c1.EmailAddress = "baggins@lotr.com";
            Customer.InstanceCounter += 1;

            bool expectedValue = true;

            // Act
            bool actualValue = c1.Validate();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            Customer c1 = new Customer();
            c1.EmailAddress = "baggins@lotr.com";
            Customer.InstanceCounter += 1;

            bool expectedValue = false;

            // Act
            bool actualValue = c1.Validate();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ValidateMissingEmail()
        {
            // Arrange
            Customer c1 = new Customer();
            c1.LastName = "Baggins";
            Customer.InstanceCounter += 1;

            bool expectedValue = false;

            // Act
            bool actualValue = c1.Validate();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
