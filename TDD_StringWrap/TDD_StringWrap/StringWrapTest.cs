using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_StringWrap
{
    [TestClass]
    public class StringWrapTest
    {
        [TestMethod]
        public void TestNullString()
        {
            String input = null, output = null, expected = null;
            var colmax = 15;

            StringManip ObjStringManip = new StringManip();

            // Act
            output = ObjStringManip.WrapMyString(input, colmax);

            // Assert
            Assert.AreEqual(expected, output);

        }

        [TestMethod]
        // Test  The quick brown fox jumped over the lazy dog."
        public void TestSampleString()
        {
            String input = null, output = null, expected = null;
            var colmax = 15;

            StringManip ObjStringManip = new StringManip();
            input = "The quick brown fox jumped over the lazy dog.";
            expected = "The quick brown\nfox jumped over\nthe lazy dog.";

            // Act
            output = ObjStringManip.WrapMyString(input, colmax);

            // Assert
            Assert.AreEqual(expected, output);

        }

        [TestMethod]
        // Test Random string generated using "Lorem Ipsum"
        public void TestRandomString()
        {
            String input = null, output = null, expected = null;
            var colmax = 15;

            StringManip ObjStringManip = new StringManip();
            input = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            expected = "Neque porro\nquisquam est\nqui dolorem\nipsum quia\ndolor sit amet,\nconsectetur,\nadipisci\nvelit...";

            // Act
            output = ObjStringManip.WrapMyString(input, colmax);

            // Assert
            Assert.AreEqual(expected, output);

        }

        [TestMethod]
        // Test  The quick brown fox jumped over the lazy dog."
        public void TestZeroColumnValue()
        {
            String input = null, output = null, expected = null;
            var colmax = 0;

            StringManip ObjStringManip = new StringManip();
            input = "The quick brown fox jumped over the lazy dog.";
            expected = null;

            // Act
            output = ObjStringManip.WrapMyString(input, colmax);

            // Assert
            Assert.AreEqual(expected, output);

        }
    }
}
