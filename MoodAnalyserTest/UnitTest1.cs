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
        [Test]
        public void GivenNullMessage_WhenAnalye_ShouldReturnHappy()
        {
            string message = null;
            MoodAnalyser analyser = new MoodAnalyser(message);
            try
            {
                string actual = analyser.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        [Test]
        public void GivenEmptyMessage_WhenAnalye_ShouldReturnHappy()
        {
            string message = "";
            MoodAnalyser analyser = new MoodAnalyser(message);
            try
            {
                string actual = analyser.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
    }
}