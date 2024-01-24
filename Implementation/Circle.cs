using Design_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Implementation
{
    public class Circle : Ishape
    {
        public void Draw()
        {

            Console.WriteLine("A Circle");
            Console.WriteLine("  ***  ");
            Console.WriteLine(" *   * ");
            Console.WriteLine("*     *");
            Console.WriteLine(" *   * ");
            Console.WriteLine("  ***  ");

            Console.WriteLine();
        }
    }
}
