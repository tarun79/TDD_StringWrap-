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
    }
}
