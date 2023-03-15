using chain_of_responsibility_pattern.Models;

namespace chain_of_responsibility_pattern
{
    public class ApproverAbstract : IApproverHandler
    {
        private IApproverHandler? _nextHandler;

        public virtual HolidayRequest Handle(HolidayRequest request)
        {
            if (_nextHandler is not null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IApproverHandler SetNextApprover(IApproverHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }
    }
}
