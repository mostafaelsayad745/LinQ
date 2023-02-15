using Shared;

namespace Intersection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"=========== Meeting 1 participants are ({set1.Count()})");
            set2.Print($"=========== Meeting 2 participants are ({set2.Count()})");

            var set3 = set1.Intersect(set2);
            set3.Print($"=========== set1.Intersect(set2) are ({set3.Count()})");


            var set4 = set1.IntersectBy(set2.Select(x => x.EmployeeNo), x => x.EmployeeNo);
            set4.Print($"=========== set1.IntersectBy(set2.Select are ({set4.Count()})");
        }
    }
}