using System;

namespace BuiltinDelegateBasicsNameSpace
{
    class Program
    {
        delegate int SquareDelegate(int x);
        delegate void PrintMessageDelegate(int x);
        delegate bool isValidDelegate(int x);

        //Any delegate perform same task like SquareDelegate in the csharp?
        // I do't like this.
        //Func -
        static void Main()
        {
            //Defined by madan SquareDelegate
            SquareDelegate squeareMetod3 = (int x) =>
            {
                return x * x;
            };

            //Func is the csharp
            Func<int, int> squeareMetod5 =  (int x) =>
            {
                return x * x;
            };

            //Another example of the func

            //Func is the csharp
            Func<int, string> squeareMetod6 = (int x) =>
            {
                return "Hey!!!!";
            };

            //PrintMessageDelegate printMessageDelegate3 = (int x) =>
            //{
            //    Console.WriteLine("Test" + x);
            //};
            //printMessageDelegate3(10);

            Action<int> printMessageDelegate4 = (int x) =>
            {
                Console.WriteLine("Test" + x);
            };
            printMessageDelegate4(10);



            Predicate<int> isvDelegate4 = (int x) =>
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
            bool b2 = isvDelegate4(0); //true
            Console.WriteLine(b2);



        }
    }
}
