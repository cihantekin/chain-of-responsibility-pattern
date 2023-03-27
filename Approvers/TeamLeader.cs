using chain_of_responsibility_pattern.Models;

namespace chain_of_responsibility_pattern.Approvers
{
    public class TeamLeader : ApproverAbstract
    {
        public override HolidayRequest Handle(HolidayRequest request)
        {
            if (request is not null && request.RequestStatus == Status.WaitingForTeamLeaderApproval && request.TotalHolidays <= 20)
            {
                request.RequestDate = DateTime.Now;
                request.LastUpdateDate = DateTime.Now;
                request.EmployeeName = "Cihan Tekin";
                request.RequestStatus = Status.WaitingForDirectorApproval;

                Console.WriteLine($"{nameof(TeamLeader)} has approved your holiday request.");

                return request;
            }
            else
            {
                request.RequestStatus = Status.Rejected;
                request.LastUpdater = nameof(TeamLeader);
                Console.WriteLine($"{request.LastUpdater} has rejected your request!");

                return base.Handle(request);
            }

        }
    }
}
