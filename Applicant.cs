namespace Hiring_Application.Models
{
    public class Applicant
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ResumePath { get; set; } 
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending";
        public int JobId { get; set; }
        public Job Job { get; set; }
        public string RequestId { get; internal set; }
    }
}
