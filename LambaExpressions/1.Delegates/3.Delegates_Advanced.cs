using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAdvanced
{
    class Program
    {
        delegate int SquareDelegate(int x);
        delegate void PrintMessageDelegate(int x);
        delegate bool isValidDelegate(int x);



        static int Square(int x)
        {
            return x * x;
        }

        static void PrintValue(int value)
        {
            Console.WriteLine(value);
        }

        static bool isCurrentValue(int value)
        {
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        static void Main()
        {
            //Assign method signature to the delegate
            //Let's delegate take the hour work.
            SquareDelegate squeareMetod1 = Square;
            int firstDelegate = squeareMetod1(3);
            Console.WriteLine(firstDelegate);


            PrintMessageDelegate printMessageDelegate = PrintValue;
            printMessageDelegate(10);

            isValidDelegate isvDelegate = isCurrentValue;
            bool isValid = isvDelegate(0);
            Console.WriteLine(isValid);



            // 2 . Advantage.
            //delegate int SquareDelegate(int x);
            //anonymous
            //SquareDelegate squeareMetod1 = Square;

            SquareDelegate squeareMetod2 = delegate (int x)
            {
                return x * x;
            };

            SquareDelegate squeareMetod3 = (int x) =>
            {
                return x * x;
            };


            int s1 = squeareMetod2(10); // 100
            int s2 = squeareMetod3(200);
            Console.WriteLine(s1);
            Console.WriteLine(s2);


            PrintMessageDelegate printMessageDelegate2 = delegate (int x)
            {
                Console.WriteLine("Test" + x);
            };
            printMessageDelegate2(10);


            //i refer this
            PrintMessageDelegate printMessageDelegate3 = (int x) =>
            {
                Console.WriteLine("Test" + x);
            };
            printMessageDelegate3(10);



            isValidDelegate isvDelegate2 = delegate (int x)
            {
                if (x == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            bool b1 = isvDelegate2(0); //true
            Console.WriteLine(b1);

            isValidDelegate isvDelegate3 = (int x) =>
            {
                if (x == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            bool b2 = isvDelegate3(0); //true
            Console.WriteLine(b2);


        }

    }
}
