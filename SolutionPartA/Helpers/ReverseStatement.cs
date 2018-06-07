using System;
using System.Text;

namespace SolutionPartA.Helpers
{
    public static class ReverseStatement
    {
        public static string Reverse(string sentence)
        {
            string output = "";
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return "";
            }
            if (sentence.Contains(" "))
            {
                StringBuilder sb = new StringBuilder();
                var words = sentence.Split(" ");
                for (int count = 0; count < words.Length; count++)
                {
                    sb.Append(ReverseWord(words[count]));
                    if (count != words.Length - 1)
                    {
                        sb.Append(" ");
                    }
                }
                output = sb.ToString();
            }
            else
            {
                output = ReverseWord(sentence);
            }

            return output;

        }

        private static string ReverseWord(string str)
        {
            string output = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                output += str[i];
            }
            return output;
        }
    }
}
