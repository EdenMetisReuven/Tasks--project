using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumericalExpression num = new NumericalExpression(2);
            int sumLetter = NumericalExpression.SumLetters(2);
            Console.WriteLine(num.GetValue());
            Console.WriteLine(num.ToString());
            Console.WriteLine(sumLetter);

        }
    }
}