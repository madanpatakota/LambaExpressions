using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesBasicsNamespace
{

    /* Delegate : 
 *   Delegate in Csharp is nothing but a functional pointer which contains the function reference.
 *   Usually we use delegates as a function reference parameter while we are calling the method.
 *   
 *   Delegate do't have any implementaion.
 * */

    //1.45
    public delegate int Operation(int x, int y);
    //public delegate string Operation1(string x,string y , int z);

    class Calculator
    {
        public int PerformOperation(int x , int y,Operation operation)
        {
            return operation(x,y); // operaion here contains add referece.
        }

    }

    // F10 is the nextline
    // F11 is the inside of the function.

    class Program
    {
        //Core..
        public static int add(int x , int y)
        {
            return x + y;
        }

        public static int subtract(int x, int y)
        {
            return x - y;
        }


        public static int mulitply(int x, int y)
        {
            return x * y;
        }

        
        static void Main()
        {
            //Program program = new Program();

            //add(1, 2);

            Calculator calculator = new Calculator();

            int addtionResult = calculator.PerformOperation(1,2,add);


            int subtractResult = calculator.PerformOperation(20, 10, subtract);


            int multiplyResult = calculator.PerformOperation(20, 10, mulitply);



            //program.add(1, 2); // Directly i am calling.
            //program.subtract(1, 2); // Direcely i am calling.

            Console.ReadLine();

        }
    }
}
