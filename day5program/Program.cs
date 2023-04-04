using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace day5program
{
    internal class Program
    {
        public delegate void whatToEat();
        public delegate void WhatToEats(string food);
        static void Main(string[] args)
        {
            Animal cow = new Animal();
            whatToEat eat=new whatToEat(cow.whatIeat);
            eat += cow.Function1;
            WhatToEats eats=new WhatToEats(cow.whatIeat);
            eat();
            eats("STRAW");
            Console.ReadKey();
        }
        //FIRST PROGRAM
        //static void Main(string[] args)
        //{
        //    Function1();
        //    Function2();
        //    //function2 first ma rakhera fuction1 second ma rakhda mix ma output aauxa kina vane function2 ma naya thread banako xa so aagadi paxadi parxa 
        //    Console.ReadKey();
        //}
        //public static void Function1()
        //{
        //    int Counter;
        //    for(Counter=0;Counter<=50;Counter++)
        //    {
        //        Console.WriteLine("I am from function1");
        //    }
        //    Console.ReadKey();
        //}
        //public static async void Function2()
        //{
        //    await Task.Run(() =>
        //    {
        //        int Counter;
        //        for (Counter = 0; Counter <= 50; Counter++)
        //        {
        //            Console.WriteLine("I am from function2");
        //        }
        //    });
        //}
    }
}
