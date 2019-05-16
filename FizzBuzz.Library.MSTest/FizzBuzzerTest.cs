using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;



namespace FizzBuzz.Library.MSTest
{
    [TestClass]
    public class FizzBuzzerTest
    {
        //[TestMethod]
        //public void FizzBuzz_When1_Return1()
        //{
        //    //Arrange
        //    int input = 1;

        //    //Act
        //    string output = FizzBuzzer.GetValue(input);

        //    //Assert
        //    Assert.AreEqual("1", output);
        //}

        //https://www.youtube.com/watch?v=l4xhTq4qmC0 YOUTUBE LINK

        [DataRow(1)]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(19)]
        [DataTestMethod]
        public void FizzBuzz_WhenDefault_ReturnInput(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        [DataRow(18)]
        [DataTestMethod]
        public void FizzBuzz_WhenDiv3_ReturnFizz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [DataRow(5)]
        [DataRow(10)]
        [DataRow(20)]
        [DataTestMethod]
        public void FizzBuzz_WhenDiv5_ReturnsBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [DataRow(15)]
        [DataTestMethod]
        public void FizzBuzz_WhenDiv3And5_ReturnsFizzBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
