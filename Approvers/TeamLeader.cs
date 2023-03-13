namespace chain_of_responsibility_pattern.Approvers
{
    public class TeamLeader : ApproverAbstract
    {
        public override object Handle(object request)
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
