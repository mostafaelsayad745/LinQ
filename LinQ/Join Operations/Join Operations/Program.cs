using LINQTut09.Shared;
using System.Linq;

namespace Join_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunJoin();
            //RunJoinQuerySyntax();
            //RunGroupJoin();
            //RunGroupJoinQuerySyntax();
        }
        private static void RunGroupJoinQuerySyntax()
        {
            var employee = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();

            var result = from dept in department
                         join emp in employee
                         on dept.Id equals emp.DepartmentId into empGroup
                         select empGroup;


            foreach (var g in result)
            {
                Console.WriteLine($"++++++Group++++++++");
                foreach (var item in g)
                {
                    Console.WriteLine($"\t {item.FullName}");
                }
            }
        }

        private static void RunGroupJoin()
        {
            var employee = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();

            var result = department.GroupJoin(
                employee,
                dept => dept.Id,
                emp => emp.DepartmentId,
                (dept, emp) => new Group
                {
                    Department = dept.Name,
                    Employees = emp.Select(e => e.FullName).ToList(),
                });
                

            foreach (var g in result)
            {
                Console.WriteLine($"++++++{g.Department}++++++++");
                foreach (var name in g.Employees)
                {
                    Console.WriteLine($"\t {name}");
                }
            }
        }

        private static void RunJoinQuerySyntax()
        {
            var employee = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();

            var result = from emp in employee
                         join dept in department on emp.DepartmentId equals dept.Id
                         select new EmployeeDto
                         {
                             FullName = emp.FullName,
                             Departmentt = dept.Name,
                         };


            foreach (var item in result)
            {
                Console.WriteLine($"{item.FullName} [{item.Departmentt}]");
            }
        }

        private static void RunJoin()
        {
            var employee = Repository.LoadEmployees();
            var department = Repository.LoadDepartment();

            var result = employee.Join(
                department,
                emp => emp.DepartmentId,
                dept => dept.Id,
                (emp , dept ) => new EmployeeDto
                {
                    FullName = emp.FullName,
                    Departmentt = dept.Name,
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FullName}\t\t [{item.Departmentt}]");
            }
        }
    }
}