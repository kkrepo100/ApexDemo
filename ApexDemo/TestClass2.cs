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
            return "Welcome To LearningMate Employee" + abc;
        }
        public string GetWelcome(string UserName)
        {
            return "Welcome To LearningMate .net group" + UserName;
        }
    }
}