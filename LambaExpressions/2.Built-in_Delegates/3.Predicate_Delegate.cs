using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateLambdaNamesapce
{
    internal class Program
    {
        static void Main()
        {
            Predicate<int> predicate1 = (int x) =>
            {
                return true;
            };
            bool result1= predicate1(1);
            Console.WriteLine(result1);

            Predicate<int> predicate2 = (int x) =>
            {
                return false;
            };
            bool result2 = predicate2(1);
            Console.WriteLine(result2);

            Predicate<string> predicate3 = (string x) =>
            {
                return false;
            };
            bool result3 = predicate3("Test");
            Console.WriteLine(result3);
            
            Predicate<bool> predicate4 = (bool y) =>
            {
                return false;
            };
            bool result4 = predicate4(true);
            Console.WriteLine(result4);


            Predicate<int> predicate5 = (number) =>  number % 2 == 0 ;
            bool restul5 = predicate5(10);
            Console.WriteLine(restul5);


            // If you ask me please show me real time project(DI)

            // i will ask you explain the DI..



        }
    }
}


//Single room

//House -> Design 1 kitchn 1 restroom 1 livinghall 

//DI - design pattern - 2 mins discussion 
//20 days

//80 func , action and predicat
//20 DI


//Interface
//class with constructor metthod fields 
