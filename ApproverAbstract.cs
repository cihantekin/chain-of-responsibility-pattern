namespace chain_of_responsibility_pattern
{
    public class ApproverAbstract : IApproverHandler
    {
        private IApproverHandler? _nextHandler;

        public virtual object Handle(object request)
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
