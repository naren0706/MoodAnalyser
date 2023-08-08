using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserException:Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,EMPTY_MOOD
        }
        public ExceptionType type { get; set; }
        public MoodAnalyserException(ExceptionType type,string message):base(message)
        {
            this.type = type;
        }
    }
}
