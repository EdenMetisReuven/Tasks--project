using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class NumericalExpression
    {
        private long number;
        public NumericalExpression(long Number)
        {
            this.number = Number;
        }



        public long GetValue()
        {
            return number;
        }
        public override string ToString()
        {
            string numberToWord = " ";
            if (number >= 1000000000)
            {
                numberToWord += NumberToString(number / 1000000000) + " billion ";
                number = number % 1000000000;

            }

            if (number >= 1000000)
            {
                numberToWord += NumberToString(number / 1000000) + " million ";
                number = number % 1000000;

            }

            if (number >= 1000)
            {
                numberToWord += NumberToString(number / 1000) + " thousand ";
                number = number % 1000;

            }

            if (number < 1000)
            {
                numberToWord += NumberToString(number);

            }

            return (numberToWord);
        }

        public string NumberToString(long number)
        {
            string numberToWord = "";
            string[] oneToNinty = { "","one", "two", "three", "four", "five", "six","seven", "eight", "nine", "ten",
                "eleven","twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] tenths = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (number >= 100)
            {
                numberToWord += oneToNinty[number / 100] + " hundred ";
                number = number % 100;

                if (number / 10 != 0)
                {
                    numberToWord += "and ";
                }
            }

            if (number >= 20)
            {

                numberToWord += tenths[number / 10] + " ";

                number = number % 10;

            }

            if (number >= 1)
            {
                numberToWord += oneToNinty[number];
            }
            return (numberToWord);
        }



        //פולימורפיזם היא תכונה המאפשרת לנו להתייחס לאובייקטים בצורה גמישה,
        //המתאימה לצרכינו, בדרך כלל על ידי שימוש בתכונה ההורשה.
        //לרוב מדובר בטיפול זהה אובייקטים מטיפוסים שונים בעזרת מחלקת אב משותפת, או ממשק שהם מקיימים.
        //פולימורפיזם 
        //מאפשר לנו להשתמש בתכונות או פעולות של אובייקטים בלי להיות תלויים במימוש שלהם.
        //ונותן לנו להגדיר יותרלהגדיר פעולה יותר מדרך אחת, ומאפשר  לנו בנייה של כמה פעולות בעלות אותו
        //השם אבל עם משתנים שוני, בסוגם ובערכם.
        public static long SumLetters(NumericalExpression number)
        {
            
            long countLetters = 0;
            long countTab = 0;
            string numberToString;
            while (number.number != 0)
            {
                numberToString = number.ToString();
                countLetters += numberToString.Length;
                for (int i = 0; i < numberToString.Length; i++)
                {
                    if (numberToString[i] == ' ')
                        countTab++;
                }
                countLetters -= countTab;
                countTab = 0;
                number.number -- ;
            }
            return countLetters;
          
        }

    }

}