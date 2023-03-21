// See https://aka.ms/new-console-template for more information
using chain_of_responsibility_pattern;
using chain_of_responsibility_pattern.Approvers;

Console.WriteLine("Hello, World!");


ApproverAbstract teamLead = new TeamLeader();
ApproverAbstract director = new Director();
ApproverAbstract boss = new Boss();

teamLead.SetNextApprover(director);
director.SetNextApprover(boss);