﻿namespace chain_of_responsibility_pattern.Models
{
    public class HolidayRequest
    {
        public string EmployeeName { get; set; }
        public DateTime RequestDate { get; set; }
        public Status RequestStatus { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
