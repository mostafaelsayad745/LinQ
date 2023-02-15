using Shared;

namespace Standrad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunCount();
            RunMax();
            // RunMaxby();

            //RunMin();
            //RunMinby();
            //RunSum();
            //RunAvg();
        }

        private static void RunMax()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 100));
            var maximumMark = quiz.Max(x => x.CorrectAnswer);
            var maximumMark1 = quiz.Where(x => x.Choices.Count()<3).Max(x => x.CorrectAnswer);
            Console.WriteLine(maximumMark);
        }
        private static void RunMaxby()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 100));
            var maximumMark = quiz.MaxBy(x => x.CorrectAnswer);
            
            Console.WriteLine(maximumMark);
        }

        private static void RunMin()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 100));
            var maximumMark = quiz.Min(x => x.CorrectAnswer);
            var maximumMark1 = quiz.Where(x => x.Choices.Count() < 3).Min(x => x.CorrectAnswer);
            Console.WriteLine(maximumMark);
        }
        private static void RunMinby()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 100));
            var maximumMark = quiz.MinBy(x => x.CorrectAnswer);

            Console.WriteLine(maximumMark);
        }

        private static void RunCount()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 100));
            Console.WriteLine(quiz.Count());
            Console.WriteLine(quiz.Count(x => x.CorrectAnswer == 1));
            Console.WriteLine(quiz.Where(x => x.CorrectAnswer == 1).Count());

            Console.WriteLine(quiz.Where(x => x.CorrectAnswer == 1).LongCount());
        }

        private static void RunSum()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 100));
            var total = quiz.Sum(x => x.CorrectAnswer);
            
            Console.WriteLine(total);
        }
        private static void RunAvg()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 100));
            var avg = quiz.Average(x => x.CorrectAnswer);
            
            Console.WriteLine(avg);
        }
    }
}