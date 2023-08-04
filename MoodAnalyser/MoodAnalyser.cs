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
            try
            {
                if (this.message.ToLower().Contains("sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}