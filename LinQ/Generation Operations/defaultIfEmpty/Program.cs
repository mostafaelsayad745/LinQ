using Shared;
namespace defaultIfEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var question = Enumerable.Empty<Question>();
            var question2 = question.DefaultIfEmpty();
            var question3 = question.DefaultIfEmpty(Question.Default);
            question2.ToQuiz();
        }
    }
}
// Note : if you need more information loot at the WORD file