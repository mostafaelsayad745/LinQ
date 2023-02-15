using LINQTut06.Shared;
using LINQTut08.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Grouping_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGroupBy();
            //RunGroupByUsingQuery();
        }

        private static void RunGroupBy()
        {
            var emps = Repository.LoadEmployees();

            var result = emps.GroupBy(x => x.Department);

             IEnumerable<IGrouping<string, Employee>> result1 = emps.GroupBy(x => x.Department);

            // key : hr , value : mostafa
            // key : hr , value : omar
            foreach (var Group in result1)
            {
                Group.Print($"Employees in {Group.Key} Department");
            }
        }

        private static void RunGroupByUsingQuery()
        {
            var emps = Repository.LoadEmployees();

            var result = from emp in emps
                         group emp by emp.Department;

            
            foreach (var Group in result)
            {
                Group.Print($"Employees in {Group.Key} Department");
            }
        }
    }
}
