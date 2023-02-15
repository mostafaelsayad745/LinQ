using Shared;

namespace ElementAt_ElementAtOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            var questionAt10 = questions.ElementAt(10);
            Console.WriteLine(questionAt10);


            var questionAt1000 = questions.ElementAtOrDefault(1000);
            Console.WriteLine(questionAt1000);
        }
    }
}