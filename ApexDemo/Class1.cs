using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit;
using NUnit.Framework;

namespace ApexDemo
{
    public class Class1
    {
        
        string con = ""; // Connection String
        [Test]
        public void TestMethod1()

        {

            //Expected

            bool expected_result = true;

            //Actual

            bool actual_result = true;

            Assert.AreEqual(expected_result, actual_result, "Test is passed")
        
}
    }
}