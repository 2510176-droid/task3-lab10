namespace task3.Components
{
    public class Course
    {
        public int RegistrationId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public string CourseCode { get; set; } = string.Empty;
        public string CourseTitle { get; set; } = string.Empty;
        public int CreditHours { get; set; }
        public string Semester { get; set; } = string.Empty;
    }
}
