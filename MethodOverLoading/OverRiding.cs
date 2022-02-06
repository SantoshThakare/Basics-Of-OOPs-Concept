using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
        
    }
    public class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }

    }
}
