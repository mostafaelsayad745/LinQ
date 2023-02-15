using Shared;
using System.Security.Cryptography.X509Certificates;

namespace Aggregate_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMethod1();
        }
        private static void RunMethod1()
        {
            var names = new[] { "mostafa", "ahmed", "hamed", "elsayad", "omar" };

            //var output = "";
            //foreach (var item in names)
            //{
            //    output += $"{item} ,";
            //}
            //Console.WriteLine(output.TrimEnd(','));


            //var output = string.Join(',',names);
            //Console.WriteLine(output);

            var commaSepratedName = names.Aggregate((a,b) => 
            {
                Console.WriteLine($"a = {a} , b = {b}");
                return $"{a},{b}";
            });
            Console.WriteLine(commaSepratedName);
        }
        private static void RunMethod2()
        {
            var names = new[] { 1, 2, 3, 4, 5 };
            var total = 0;
            foreach (var item in names)
            {
                total += item;
            }
            Console.WriteLine(total);

            var commaSepratedName = names.Aggregate(2,(a, b) => // a+b
            {
                return a+b;
            });
            Console.WriteLine(commaSepratedName);
        }
        private static void RunMethod3()
        {
            var questions = QuestionBank.All;
            var longestQuestionTitle = questions[0];

            longestQuestionTitle = questions.Aggregate(longestQuestionTitle,
                (longest, next) => longest.Title.Length < next.Title.Length ? next : longest
                ,q => q);
            Console.WriteLine(longestQuestionTitle);
        }
    }
}