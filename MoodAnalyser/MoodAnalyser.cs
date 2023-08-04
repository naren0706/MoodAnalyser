namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}