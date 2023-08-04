namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (this.message.ToLower().Contains("sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}