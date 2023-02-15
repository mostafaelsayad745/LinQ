using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public static class ExtensionFunctional01
    {
        public static IEnumerable<Employee> Filter(this IEnumerable<Employee> sourse,Func<Employee,bool> predicate)
        {
            
            foreach (var employee in sourse)
            {
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }

        

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
                Console.WriteLine(item);
        }

    }
}