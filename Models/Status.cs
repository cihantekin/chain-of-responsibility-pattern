namespace chain_of_responsibility_pattern.Models
{
    public enum Status
    {
        WaitingForTeamLeaderApproval = 0,
        WaitingForDirectorApproval = 1,
        WaitingForBossApproval = 2
    }
}
