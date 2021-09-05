using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DT.DotNet.Common.Test
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "SonicScrewdriver";
            
            var expected = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpaces()
        {
            var source = "Sonic Screwdriver";

            var expected = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
