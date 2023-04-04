using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace day5program
{
    public class Animal
    {
        public void whatIeat()
        {
            Console.WriteLine("I eat grass");
        }
        public void whatIeat(string food)
        {
            Console.WriteLine("I eat " + food);
        }
        public void Function1()
        {
            Console.WriteLine("Hi I am function1");
        }
    }
}
