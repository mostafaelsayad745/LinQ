using Shared;

namespace Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var question = new List<Question>(); // empty list  // intermidate way
            // 1
            //....
            // 1000
            foreach (var q in question)
            {
                Console.WriteLine(q);
            }

            var question2 = Enumerable.Empty<Question>(); // empty list  // deferred way
            // 1
            //....
            // 1000
            foreach (var q in question)
            {
                Console.WriteLine(q);
            }
        }
    }
}
// Note : if you want to know more look at the WORD file