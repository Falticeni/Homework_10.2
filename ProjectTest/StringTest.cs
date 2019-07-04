using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//using ProjectTest.Classes

namespace ProjectTest
{
    [TestFixture] // clasa in care se face test   
    class StringTest
    {
        [TestCase("ab-cd", "dc-ba")] // un caz de testare
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")] 
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [TestCase("", "")]
        [TestCase("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")] 
        public void Check(string S, string output)
        {
            Classes.ReversedString revers = new Classes.ReversedString();

            var input = revers.ReverseString(S);

            Assert.AreEqual(output, input);
        }
    }
}
