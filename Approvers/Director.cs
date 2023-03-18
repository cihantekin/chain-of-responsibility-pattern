﻿using chain_of_responsibility_pattern.Models;

namespace chain_of_responsibility_pattern.Approvers
{
    public class Director : ApproverAbstract
    {
        public override HolidayRequest Handle(HolidayRequest request)
        {
            if (request is not null && request.RequestStatus == Status.WaitingForTeamLeaderApproval && request.TotalHolidays <= 20)
            {
                request.RequestDate = DateTime.Now;
                request.LastUpdateDate = DateTime.Now;
                request.EmployeeName = "Cihan Tekin";
                request.RequestStatus = Status.WaitingForDirectorApproval;

                return request;
            }
            else
            {
                return base.Handle(request);
            }

        }
    }
}