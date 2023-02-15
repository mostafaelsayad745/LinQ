using Shared;

namespace Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMethod1();
            RunMethod2();
            RunMethod3();
        }

        private static void RunMethod1()
        {
            var q1 = QuestionBank.PickOne();
            var q2 = QuestionBank.PickOne();
            var q3 = QuestionBank.PickOne();

            var Quiz1 = new List<Question>(new[] {q1,q2, q3});
            var Quiz2 = new List<Question>(new[] {q1,q2, q3});

            var equal = Quiz1.SequenceEqual(Quiz2);

            Console.WriteLine($"quiz1 and quiz2 {(equal ? "are":"are not")} equal");
        }
        private static void RunMethod2()
        {
            var RandomFourQuestions = QuestionBank.GetQuestionRange(Enumerable.Range(1,4));
            

            var Quiz1 =  RandomFourQuestions;
            var Quiz2 =  RandomFourQuestions;

            var equal = Quiz1.SequenceEqual(Quiz2);

            Console.WriteLine($"quiz1 and quiz2 {(equal ? "are" : "are not")} equal");
        }
        private static void RunMethod3()
        {


            var Quiz1 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4)); ;
            var Quiz2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4)); ;

            var equal = Quiz1.SequenceEqual(Quiz2);

            Console.WriteLine($"quiz1 and quiz2 {(equal ? "are" : "are not")} equal");
        }
    }
}