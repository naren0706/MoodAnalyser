using System.Security.Cryptography.X509Certificates;
using MoodAnalyserProblem;
namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalye_ShouldReturnSad()
        {
            string message = "I am in sad mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyseMood();
            Assert.AreEqual(actual, "SAD");
        }
        [Test]
        public void GivenAnyMessage_WhenAnalye_ShouldReturnHappy()
        {
            string message = "I am in any mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyseMood();
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}