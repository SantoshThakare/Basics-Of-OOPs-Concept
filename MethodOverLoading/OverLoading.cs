using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    public class OverLoading
    {
        public void Add( int a, int b)
        {
            Console.WriteLine("a + b =" + (a + b));
            Console.ReadLine();
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("a + b +c  =" + (a + b + c));
            Console.ReadLine();
        }


    }
}
