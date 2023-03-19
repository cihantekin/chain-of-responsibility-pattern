using chain_of_responsibility_pattern.Models;

namespace chain_of_responsibility_pattern.Approvers
{
    public class Boss : ApproverAbstract
    {
        public override HolidayRequest Handle(HolidayRequest request)
        {
            if (request is not null && request.RequestStatus == Status.WaitingForBossApproval && request.TotalHolidays <= 20)
            {
                request.LastUpdateDate = DateTime.Now;
                request.RequestStatus = Status.Approved;

                return request;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
