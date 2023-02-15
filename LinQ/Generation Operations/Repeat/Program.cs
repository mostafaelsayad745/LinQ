using Shared;

namespace Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var q = QuestionBank.PickOne();

            var questions = Enumerable.Repeat(q,10).ToList();

            Console.WriteLine(ReferenceEquals(questions[0], questions[1]));
            questions.ToQuiz();


            var question2 = new List<Question>();
            for (int i = 0; i < 10; i++)
            {
                question2.Add(new Question());
            }
            //Console.WriteLine(ReferenceEquals(question2[0], question2[1]));
        }
    }
}