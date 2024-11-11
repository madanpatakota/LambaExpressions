using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateNamespace
{
    internal class Program
    {
        static void Main()
        {
            //Action<int> action1 = (int x) =>
            //{
            //    Console.WriteLine(x);
            //};
            //action1(10);




            //Action<string> action2 = (string x) =>
            //{
            //    Console.WriteLine(x);
            //};
            //action2("Helow");


            //Action<int, string> action3 = (int x, string y) =>
            //{
            //    Console.WriteLine($"{x} {y}");
            //};

            //action3(10,"Hello");


            Action<string, int, double, string> action4 = (fname , age , salary , lName) =>
            //Action<string, int, double, string> action4 = (string x, int y, double a, string b) =>
            {
                Console.WriteLine($"First name is {fname}");
                Console.WriteLine($"Age is {age}");

                int updatedage = age + 20;
                Console.WriteLine(updatedage);
                Console.WriteLine($"updatedage is {updatedage}");

                Console.WriteLine($"Salary is {salary}");
                Console.WriteLine($"LName {lName}");

            };
            //action4("John", 30, 20000.90, "Smith");


            //Action<int> action1 = (int x) =>
            //{
            //    Console.WriteLine(x);
            //};
            //action1(10);

            Action<int> action1 = x =>
            {
                Console.WriteLine(x);
            };
            //action1(10);

            List<int> data = new List<int>() { 10, 20, 30, 40 };
            // data.ForEach(x => { Console.WriteLine(x);});

            data.ForEach(x => {
                x = x + 100;
            });
            Console.WriteLine(data);








            //16 Parameers



        }
    }
}
