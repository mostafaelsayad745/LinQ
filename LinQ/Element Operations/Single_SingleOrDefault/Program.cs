using Shared;

namespace Single_SingleOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

           // var question1 = questions.Single(x => x.Title.Contains("#245")); //must be unique
            //var question2 = questions.SingleOrDefault(x => x.Title.Contains("#245")); // must be unique
            //var question3 = questions.Single(x => x.Title.Length == 0); // must be there is at least one element
            var question4 = questions.SingleOrDefault(x => x.Title.Length == 0);

            if (question4 is null)
            {
                Console.WriteLine("question4 is null");
            }
        }
    }
}