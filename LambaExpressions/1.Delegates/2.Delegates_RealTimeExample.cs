using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegagtesRealtimeExample
{

    //Delegate

    public delegate double BonusCalculator(double salary);

    class Employee
    {
        //public string Name;//Field
        public string Name { get; set; } //Property
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public double CalculteBonus(BonusCalculator bonusCalculator)
        {
            return bonusCalculator(Salary); //standardbonus
        }
    }

    class Program
    {
        static double StandardBonus(double salary)
        {
            return salary * 0.05;
        }
        static double HighPerformanceBonus(double salary)
        {
            return salary * 0.1;
        }

        static void Main()
        {
            //double emp1Bonus =  Program.StandardBonus(10300);  
            //double emp2Bonus =  Program.HighPerformanceBonus(10300);

            //with help of the delegates

            Employee employee1 = new Employee("Employee1" , 70000);
            double emp1Bonus   = employee1.CalculteBonus(Program.StandardBonus);


            Employee employee2 = new Employee("Employee2", 80000);
            double emp2Bonus = employee2.CalculteBonus(Program.HighPerformanceBonus);


            Console.ReadLine();
        }
    }

}
   

