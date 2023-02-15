using System.Linq.Expressions;

namespace Expression_Trees_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func <int,bool> IsEven = x => x%2 == 0;
            Console.WriteLine(IsEven(10));
            Console.WriteLine(IsEven.Invoke(10));

            Expression<Func<int,bool>> IsEvenExperssion = x => x%2 == 0;
            Func<int, bool> IsEven3 = IsEvenExperssion.Compile();
            Console.WriteLine(IsEven3(10));
        }
    }
}