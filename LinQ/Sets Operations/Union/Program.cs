using Shared;

namespace Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"=========== Meeting 1 participants are ({set1.Count()})");
            set2.Print($"=========== Meeting 2 participants are ({set2.Count()})");

            var set3 = set1.Union(set2);
            set3.Print($"=========== set1.Union(set2) are ({set3.Count()})");


            var set4 = set1.UnionBy(set2, x => x.EmployeeNo);
            set4.Print($"=========== set1.UnionBy(set2.Select are ({set4.Count()})");
        }
    }
}