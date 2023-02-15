using Shared;
namespace Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            var lastQuestion = questions.Last();
            Console.WriteLine(lastQuestion);

            //var someQuestion = questions.Last(x => x.Title.Length == 0); // invalid operation exception

            var someOtherQuestion = questions.LastOrDefault(x => x.Title.Length == 0);

            if (someOtherQuestion is null)
            {
                Console.WriteLine("question is null");
            }
            Console.ReadKey();
        }
    }
}