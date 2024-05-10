using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Program
    {
        static void Main()
        {
            NumericalExpression num = new NumericalExpression(2);
            Console.WriteLine(num.GetValue());
            Console.WriteLine(num.ToString());
            int sumLetter = NumericalExpression.SumLetters(2);
            Console.WriteLine(sumLetter);

        }
    }
}