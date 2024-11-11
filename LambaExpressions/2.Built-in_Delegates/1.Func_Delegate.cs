using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegateNamespace
{
    internal class Program
    {
        static void Main()
        {
            //Func<int, int> func1 = (int x) =>
            //{
            //    return x + 10;
            //};

            //int result1 = func1(10);
            //Console.WriteLine(result1); //20

            List<double> vegitablePricees = new List<double>()
            {
                10.09, 20.90, 40.89,90.89
            };

            //Average of this price
            Func<List<double>, double> average = (List<double>  items) =>  items.Average();
            double a1 =  average(vegitablePricees);//
            Console.WriteLine(a1);


            double someValue = 10.09;
            Func<List<double>, bool> func20 = (List<double> items) => items.Contains(someValue);
            bool a2 = func20(vegitablePricees); //true
            Console.WriteLine(a2);

            //JS filter find

            Func<List<double>, bool> func4 = (List<double> items) => items.All(x => x == 10);
            func4(vegitablePricees); //false
            bool a3 = func4(vegitablePricees); //true
            Console.WriteLine(a3);

            Func<List<double>, bool> func5 = (List<double> items) => items.All(x => x > 10);
            func5(vegitablePricees); //true
            bool a4 = func5(vegitablePricees); //true
            Console.WriteLine(a4);


            Func<List<double>, bool> func6 = (List<double> items) => items.Any(x => x > 40);
            func6(vegitablePricees); //true
            bool a5 = func6(vegitablePricees); //true
            Console.WriteLine(a5);

            //Where  Ienumrable to list
            Func<List<double>, List<double>> func7 = (List<double> items) => items.Where(x => x > 20).ToList();
            func6(vegitablePricees);  //20.90, 40.89,90.89
            List<double> a6 = func7(vegitablePricees); //true
            foreach(double item in a6)
            {
                Console.WriteLine(item);
            }

            List<int> data = new List<int>() { 10, 20, 30, 40 };
            Func<List<int>, List<int>> func8 = (values) => values.Select(x => x + 100).ToList();
            func8(data);
            foreach (int item in data)
            {
                Console.WriteLine(item);
            }







            //Func<int,int, int> func2 = (int x,int y) =>
            //{
            //    return x + y + 10;
            //};

            //int result2 = func2(10,20);
            //Console.WriteLine(result2); //40


            //Func<int, string, int> func10 = (int x, string y) =>
            //{
            //    Console.WriteLine($"{x} {y}");
            //    return 1;
            //};

            //int result3 = func10(10, "Test");
            //Console.WriteLine(result3); //1

            ////16
            //Func<int, string, string> func11 = (int x, string y) =>
            //{
            //    Console.WriteLine($"{x} {y}");
            //    return "Hello";
            //};

            //string result4 = func11(10, "Test");
            //Console.WriteLine(result4); //1
        }
    }
}
