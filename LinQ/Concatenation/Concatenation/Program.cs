using Shared;

namespace Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunMethod1();
            RunMethod3();
        }

        private static void RunMethod2()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);
            var quiz3 = QuestionBank.GetQuestionRange(Enumerable.Range(11, 14));
            var questionTitles =
                quiz1.Select(q => q.Title).Concat(quiz2.Select(q =>q.Title))
                .Concat(quiz3.Select(q => q.Title));

            foreach (var title in questionTitles)
            {
                Console.WriteLine(title);
            }
        }

        private static void RunMethod1()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);
            

            var quiz3 = quiz1.Concat(quiz2);

            quiz3.ToQuiz();
        }

        private static void RunMethod3()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);


            var quiz3 = new[] { quiz1, quiz1 }.SelectMany(q => q);
            

            quiz3.ToQuiz();
        }
    }
}