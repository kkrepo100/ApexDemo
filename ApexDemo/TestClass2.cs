using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
namespace ApexDemo
{
    public class TestClass2
    {
        public string GetNames(string abc)
        {
            return "Welcome To  Employee 100" + abc;
        }
        public string GetWelcome(string UserName)
        {
            return "Welcome  LearningMate .net group" + UserName;
        }
    }
}