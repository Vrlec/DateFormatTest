using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DateFormat;

namespace Formatting
{
    [TestClass]
    public class DateFormatTest
    {
        [TestMethod]
        public void Test()
        {
            // Create the date and the formats
            DateFormatClass Format = new DateFormatClass();
            Date Date1 = new Date();
            Date1.SetDate(1, 8, 3000);

            // Adding values to properties
            string Ch = Format.Formation(Date1, "CH");
            string Us = Format.Formation(Date1, "US");
            string Iso = Format.Formation(Date1, "ISO");

            string Isu = Format.Formation(Date1, "ISU");

            // Check if they are as expected
            Assert.AreEqual("01.08.3000", Ch);
            Assert.AreEqual("08/01/3000", Us);
            Assert.AreEqual("3000-08-01", Iso);
            Assert.AreEqual("ERROR: This Date format does not exist!", Isu);
        } // Testmethod
    } // class UnitTest
} // Namespace DateFormatTest2