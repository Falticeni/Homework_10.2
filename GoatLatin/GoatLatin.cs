using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    public static class GoatLatin
    {
        public static string ToGoatLatin(string S)
        {
            string[] sentence = S.Split(' ');

            StringBuilder sb = new StringBuilder();
            for (int word = 0; word < sentence.Length; word++)
            {
                if ((sentence[word].ToLower()[0] == 'a') ||
                    (sentence[word].ToLower()[0] == 'e') ||
                    (sentence[word].ToLower()[0] == 'i') ||
                    (sentence[word].ToLower()[0] == 'o') ||
                    (sentence[word].ToLower()[0] == 'u'))
                {
                    sb.Append(sentence[word]);
                    sb.Append("ma");
                }
                else
                {
                    sb.Append(sentence[word].Substring(1)); // intoarce un subsir existent incepand cu un anumit index
                    sb.Append(sentence[word][0]);
                    sb.Append("ma");
                }
                for (int i = 0; i <= word; i++)
                {
                    sb.Append('a');
                }
                if (word < sentence.Length - 1)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();


        }
    }
}
