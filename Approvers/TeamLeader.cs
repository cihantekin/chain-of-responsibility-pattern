using chain_of_responsibility_pattern.Models;

namespace chain_of_responsibility_pattern.Approvers
{
    public class TeamLeader : ApproverAbstract
    {
        public override HolidayRequest Handle(HolidayRequest request)
        {
            if (request is not null)
            {
                // do the job and return objecy
                return request;
            }
            else
            {
                return base.Handle(request);
            }

        }
    }
}
