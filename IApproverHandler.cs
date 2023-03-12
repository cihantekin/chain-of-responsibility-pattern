namespace chain_of_responsibility_pattern
{
    public interface IApproverHandler
    {
        object Handle(object request);
        IApproverHandler SetNextApprover(IApproverHandler handler);
    }
}
