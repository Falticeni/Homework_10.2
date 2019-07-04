using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class Calculator
    {
        public T Add <T>(T nr1, T nr2)
        {
            return (dynamic)nr1 + (dynamic) nr2;
        }

        public T Mul <T>(T nr1, T nr2)
        {
            return (dynamic)nr1 * (dynamic)nr2;
        }
        public T Sub <T> (T nr1, T nr2)
        {
            return (dynamic)nr1 - (dynamic)nr2;
        }
        public T Div <T>(T nr1, T nr2)
        {
            if (nr2== (dynamic)0) DivideByZeroException();
            return (dynamic)nr1 / (dynamic)nr2;
        }

        private void DivideByZeroException()
        {
            Console.WriteLine("Deimpartitul nu poate fi zero!");
        }
    }
}
