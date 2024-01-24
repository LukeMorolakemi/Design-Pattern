using Design_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Implementation
{
    public class Triangle : Ishape
    {
        public void Draw()
        {

            Console.WriteLine("A Triangle");
            Console.WriteLine("   *   ");
            Console.WriteLine("  * *  ");
            Console.WriteLine(" *   * ");
            Console.WriteLine("*******");

            Console.WriteLine();

        }
    }
}
