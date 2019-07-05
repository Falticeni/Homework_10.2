using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Classes
{
    public static class ReversedString
    {
        public static string ReverseString(string S)
        {
            if (S == "")
            {
                throw new ArgumentNullException();
            }

            char[] stringS = S.ToCharArray(); // convert string S to CharArray
            int a = 0; // start point of stringS array
            int z = stringS.Length - 1; // end point of stringS array

            while (a < z) // travers the array
            {
                if (!char.IsLetter(stringS[a])) { a++; }
                else if (!char.IsLetter(stringS[z])) { z--; }
                else
                {
                    char second = stringS[a]; // create char second to memory initial strinsgS[a]
                    stringS[a] = stringS[z]; // reverse
                    stringS[z] = second; // reverse
                    a++;
                    z--;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (var caracter in stringS)
            {
                sb.Append(caracter);
            }
            return sb.ToString();
        }
    }
}
