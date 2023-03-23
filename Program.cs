// See https://aka.ms/new-console-template for more information
using chain_of_responsibility_pattern;
using chain_of_responsibility_pattern.Approvers;
using chain_of_responsibility_pattern.Models;

Console.WriteLine("Hello, World!");


ApproverAbstract teamLead = new TeamLeader();
ApproverAbstract director = new Director();
ApproverAbstract boss = new Boss();

teamLead.SetNextApprover(director);
director.SetNextApprover(boss);

HolidayRequest holidayRequest = new()
{
    EmployeeName = "Cihan Tekin",
    RequestDate = DateTime.Now, 
    TotalHolidays = 10
};

_ = teamLead.Handle(holidayRequest);
_  = director.Handle(holidayRequest);
_ =  boss.Handle(holidayRequest);