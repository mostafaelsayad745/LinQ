using LINQTut05.Shared;
using System;
using System.Linq;

namespace Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RunAnyDemo();
            RunAllDemo();
            RunQuerySyntax();
            RunContain();
        }

        private static void RunContain()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine("RunAny");
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine();
            var emps = Repository.LoadEmployees();

            var result1 = emps.Any(x => x.Name.Contains("ee"));
            Console.WriteLine($"Check if there is an employee that has name 'ee' {result1}");

            Employee e = new Employee { Email = "Cole.Cochran01@example.com" };
            var result2 = emps.Contains(e);
            Console.WriteLine($"check if any employee object  with email exist{result2}");

            var result3 = emps.All(x => !string.IsNullOrWhiteSpace(x.Email));
            Console.WriteLine($"check if all the employees have value for email {result3}");
            }

        private static void RunQuerySyntax()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine("RunAny");
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine();
            var emps = Repository.LoadEmployees();

            var Qurey1 = from emp in emps
                         where emp.Skills.Any(s => s == "C#")  // <=
                         select emp;
            Qurey1.Print("employees with c# skills ");


            var Qurey2 = from emp in emps
                         where emp.Skills.All(s => s.Length >= 3) // <=
                         select emp;
            Qurey2.Print("employees with have 3 chars or more ");
        }

        private static void RunAllDemo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine("RunAny");
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine();


            var emps = Repository.LoadEmployees();
            var result1 = emps.All(x => !string.IsNullOrWhiteSpace(x.Email));
            Console.WriteLine($"check if all the employees have emails or not {result1}");

            var result2 = emps.All(x => x.Skills.Any(s => s == "C#"));
            Console.WriteLine($"check if all the employees have c# sill  {result2}");

        }

        private static void RunAnyDemo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine("RunAny");
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine();


            var emps = Repository.LoadEmployees();

            var result1 = emps.Any(x => x.Name.StartsWith("jac", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Check if there is any employee that start with Jac {result1}");


            var result2 = emps.Any(x => x.Salary < 10000);
            Console.WriteLine($"Check if there is any employee that his salary less than {result2}");


            var result3 = emps.Any(x => x.Skills.Count == 1);
            Console.WriteLine($"Check if there is any employee that hasone skill {result3} ");







        }
    }
}
