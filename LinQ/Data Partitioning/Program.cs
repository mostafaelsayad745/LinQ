using LINQTut06.Shared;
using System;
using System.Linq;

namespace Data_Partitioning
{
    class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Skip(10);
            q1.Print("here q1 will skip the first 10 elements of the employees");


            var q2 = emps.SkipWhile(x => x.Salary != 214400);
            q2.Print("here will skip all the employess that doesn't has this salary untill he found it after that will bring all the salaries after this salary");


            var q3 = emps.SkipLast(10);
            q3.Print("here q3 will skip the last 10 elements of the employees");
        }
    }
}
