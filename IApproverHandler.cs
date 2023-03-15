using chain_of_responsibility_pattern.Models;

namespace chain_of_responsibility_pattern
{
    public interface IApproverHandler
    {
        HolidayRequest Handle(HolidayRequest request);
        IApproverHandler SetNextApprover(IApproverHandler handler);
    }
}
