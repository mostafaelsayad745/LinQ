using LINQTut04.Shared;
using Projection_Operation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut04.SELECT
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSelectDto();
        }
        static void RunSelectName()
        {
            List<string> Words = new List<string> () { "i", "love", "c#" };
            string[] Words02 = { "i", "love", "javascript" };

            var result02 = Words02.Select(x => x.ToUpper());
            var result = Words.Select(x => x.ToUpper());

            var res = from n in Words
                      select n.ToUpper(); // this is query syntax
            foreach (var word in res)
            {
                Console.Write($"{word} ");
            }

        }
        static void RunSelectNumber()
        {
            List<int> numbers = new List<int>() { 1,2,3 };
            int[] Words02 = { 4,5,6 };

            var result02 = Words02.Select(x => x *x);
            var result =numbers.Select(x => x * x);
            foreach (var num in result)
            {
                Console.Write($"{num} ");
            }

        }
        static void RunSelectDto() // dto : is " data transfare object " to give the client the oject in another type
        {
            var emps = Repository.LoadEmployees();

           
            var result = emps.Select(x =>
            {
                return new EmployeeDto()
                {
                    Name = $"{x.FirstName} {x.LastName}",
                    TotalSkills = x.Skills.Count()
                };

            }
            );
            foreach (var item in result)
            {
                Console.WriteLine($"{item} ");
            }

        }
    }
}
