using System.Text;

namespace Garage_2._0.Utilities
{
    public static class Tool
    {
        /// <summary>
        /// Clean up the regNo by ref, and return true at success.
        /// <para> • requires alfanumeric characters as ABC123.</para> 
        /// <para> • white space characters are removed.</para> 
        /// <para> • amount characters must match the length-parameters.</para> 
        /// </summary>
        /// <param name="regNo"></param>
        /// <param name="letterLength"></param>
        /// <param name="digitLength"></param>
        public static bool FixRegNo(ref string regNo, int letterLength = 3, int digitLength = 3)
        {
            StringBuilder s = new();
            int counter = 0;
            int maxLength = letterLength + digitLength;

            foreach (char ch in regNo)
            {
                if (!char.IsWhiteSpace(ch))
                {
                    counter++;
                    if (counter > maxLength) return false;
                    if (counter <= letterLength)
                    {
                        if (!char.IsLetter(ch)) return false;
                    }
                    else if (!char.IsDigit(ch))
                        return false;

                    s.Append(ch);
                }
            }

            regNo = s.ToString().ToUpper();
            return true;
        }

        /// <summary>
        /// Returns a single space separated sentence.
        ///<para>• startSentenceWithUpperCase starts the sentence with upper case letter.</para> 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="startSentenceWithUpperCase"></param>
        /// <returns></returns>
        public static string TextToSentence(string? text, bool startSentenceWithUpperCase = true)
        {
            if (text == null) return string.Empty;
            StringBuilder sentence = new();
            string[] splited = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splited.Length; i++)
            {
                if (i == 0)
                {
                    // Start sentence with upper case letter if startSentenceWithUpperCase is true
                    if (startSentenceWithUpperCase)
                    {
                        sentence.Append(splited[i][..1].ToUpper());
                        sentence.Append(splited[i][1..]);
                    }
                    else sentence.Append(splited[i]);
                }
                else
                {
                    sentence.Append(' ');
                    sentence.Append(splited[i]);
                }
            }

            if (sentence.Length > 0)
                return sentence.ToString();
            else
                return string.Empty;
        }
    }
}
