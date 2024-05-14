using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
     class Menu
    {
        public int DirectionSelection()
        {
            Console.WriteLine("Select Direction:");
            Console.WriteLine("  1. Righr");
            Console.WriteLine("  2. Left");
            Console.WriteLine("  3. Up");
            Console.WriteLine("  4. Down");
            Console.WriteLine("  Enter your choice: ");
            int direction = Convert.ToInt32(Console.ReadLine());
            return direction;
        }
    }
}
