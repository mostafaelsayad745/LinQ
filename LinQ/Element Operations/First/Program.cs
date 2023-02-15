using Shared;
namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;
            var lastQuestion = questions.First();
            Console.WriteLine(lastQuestion);

            //var someQuestion = questions.First(x => x.Title.Length == 0); // invalid operation exception

            var someOtherQuestion = questions.FirstOrDefault(x => x.Title.Length == 0);

            if (someOtherQuestion is null)
            {
                Console.WriteLine("question is null");
            }
            Console.ReadKey();
        }
    }
}