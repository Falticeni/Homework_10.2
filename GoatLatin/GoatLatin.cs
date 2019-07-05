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
            if (S == "")
            {
                throw new ArgumentNullException();
            }

            string[] sentence = S.Split(' ');

            StringBuilder sb = new StringBuilder();
            for (int word = 0; word < sentence.Length; word++)
            {
                if ((sentence[word].ToLower()[0] == 'a') ||  // ca sa nu mai verific si pentru 'A'
                    (sentence[word].ToLower()[0] == 'e') ||
                    (sentence[word].ToLower()[0] == 'i') ||
                    (sentence[word].ToLower()[0] == 'o') ||
                    (sentence[word].ToLower()[0] == 'u'))
                {
                    sb.Append(sentence[word]);  // cuvantul
                    sb.Append("ma");            // + 'ma'
                }
                else  // in caz contrar cuvantul incepe cu o consoana
                {
                    sb.Append(sentence[word].Substring(1)); // intoarce un subsir existent incepand cu un anumit index
                    sb.Append(sentence[word][0]);           // introducem la sfarsitul cuvantului prima litera
                    sb.Append("ma");                        // + 'ma'
                }
                for (int i = 0; i <= word; i++)
                {
                    sb.Append('a');             // adaugam cate un 'a' dupa fiecare cuvant
                }
                if (word < sentence.Length - 1)
                {
                    sb.Append(" ");             // adaugam spatierea dintre cuvinte
                }
            }
            return sb.ToString();
        }
    }
}
