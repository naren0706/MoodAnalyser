using System.Security.Cryptography.X509Certificates;
using MoodAnalyserProblem;
namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalyser analyser = new MoodAnalyser();
        [Test]
        public void GivenSadMessage_WhenAnalye_ShouldReturnSad()
        {
            string message = "I am in sad mood";
            string actual = analyser.AnalyseMood(message);
            Assert.AreEqual(actual, "SAD");
        }
        [Test]
        public void GivenSadMessage_WhenAnalye_ShouldReturnHappy()
        {
            string message = "I am in any mood";
            string actual = analyser.AnalyseMood(message);
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}