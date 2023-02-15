using Shared;

namespace Distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participantm1m2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants);
            participantm1m2.Print("all the participant involved in the two meetings");

            var participantm1m2distincted = participantm1m2.Distinct();
            participantm1m2distincted.Print("all the participant involved in the two meetings distincted");


            var participantm1m2distinctBy = participantm1m2.DistinctBy(x =>x.EmployeeNo);
            participantm1m2distinctBy.Print("all the participant involved in the two meetings distinctedby");
        
    }
    }
}