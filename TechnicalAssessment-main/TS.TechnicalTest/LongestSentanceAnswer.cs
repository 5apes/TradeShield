
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        try
        {
            // split the string into sentences by '.', '!' and '?'.
            string[] sentences = s.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // initialize max word count to 0.
            int maxWordCount = 0;

            foreach (var sentence in sentences)
            {
                // Split each sentence into words and count the number of valid words
                var words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Count(word => word.Any(char.IsLetter));

                // Update maxWordCount if current sentence has more words

                if (wordCount > maxWordCount)
                    maxWordCount = wordCount;
            }

            //return max word count
            return maxWordCount;
        }
        catch(Exception ex)
        {
            throw (new Exception(ex.Message));
        }
    }
}
