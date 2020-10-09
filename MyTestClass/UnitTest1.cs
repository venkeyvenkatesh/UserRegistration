using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace MyTestClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void Name_Should_startWith_Caps_lengthIsGreaterThan3()
        {
            //arrange
            Validation obj = new Validation();
            bool expected = true;
            string name = "Venkey";

            //act
            bool actual = obj.validateName(name);

            //assert
            Assert.AreEqual(expected, actual);

        }

        
    }
}
