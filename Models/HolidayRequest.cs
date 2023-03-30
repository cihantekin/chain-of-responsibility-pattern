namespace chain_of_responsibility_pattern.Models
{
    public class HolidayRequest
    {
        public string EmployeeName { get; set; } = new("");
        public DateTime RequestDate { get; set; }
        public int TotalHolidays { get; set; }
        public Status RequestStatus { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdater { get; set; } = new("");
    }
}
