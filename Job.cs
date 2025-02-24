namespace Hiring_Application.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public List<Applicant> Applicants { get; set; } // Navigation property
    }
}

