using Shared;

namespace RangeOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = Enumerable.Range(1, 10);
           
            var questions = QuestionBank.GetQuestionRange(range);

            questions.ToQuiz();
        }
    }
}