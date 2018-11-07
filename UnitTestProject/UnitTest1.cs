using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int input = 1;


            //Act
            string output = TestClass.GetValue(input);


            //Assert
            Assert.AreEqual("sdf", output);
        }
    }
}
