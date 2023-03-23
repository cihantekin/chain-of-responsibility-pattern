using chain_of_responsibility_pattern.Models;

namespace chain_of_responsibility_pattern.Approvers
{
    public class Director : ApproverAbstract
    {
        public override HolidayRequest Handle(HolidayRequest request)
        {
            if (request is not null && request.RequestStatus == Status.WaitingForDirectorApproval && request.TotalHolidays <= 20)
            {
                request.LastUpdateDate = DateTime.Now;
                request.RequestStatus = Status.WaitingForBossApproval;

                Console.WriteLine($"{nameof(Director)} has approved your holiday request.");

                return request;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
