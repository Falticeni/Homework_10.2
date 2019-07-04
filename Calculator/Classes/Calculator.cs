using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public static class Calculator
    {
        public static T Add<T>(T nr1, T nr2)
        {
            return (dynamic)nr1 + (dynamic)nr2;
        }

        public static T Mul<T>(T nr1, T nr2)
        {
            return (dynamic)nr1 * (dynamic)nr2;
        }
        public static T Sub<T>(T nr1, T nr2)
        {
            return (dynamic)nr1 - (dynamic)nr2;
        }
        public static T Div<T>(T nr1, T nr2)
        {
            if (nr2 == (dynamic)0) { throw new DivideByZeroException(); }
            return (dynamic)nr1 / (dynamic)nr2;
        }
    }
}
