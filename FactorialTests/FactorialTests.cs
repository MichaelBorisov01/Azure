using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialCalculating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculating.Tests
{
    [TestClass()]
    public class FactorialTests
    {
        [TestMethod()]
        public void FactTest()
        {
            // arrange
            int par1 = 5;
            
            int result = 120;
            // act
            var actual = Factorial.Fact(par1);
            // assert
            Assert.AreEqual(result, actual);
        }
    }
}