using NUnit.Framework;
using FizzBuzz.Library;

namespace Tests
{
    public class FizzBuzzerTest

    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FizzBuzz_WhenDefault_ReturnsInput(
          [Values(1,2,4,7,8,11,13,14,16,17,19)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);

        }

        [Test]
        public void FizzBuzz_WhenDiv3_ReturnsFizz(
         [Values(3,6,9,12,18)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void FizzBuzz_WhenDiv5_ReturnsBuzz(
            [Values(5,10,20)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void FizzBuzz_WhenDiv3And5_ReturnsFizzBuzz(
            [Values(15)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }

    }
}