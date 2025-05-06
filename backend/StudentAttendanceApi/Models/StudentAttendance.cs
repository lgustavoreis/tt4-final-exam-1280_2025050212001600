namespace StudentAttendanceApi.Models
{
    public class StudentAttendance
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public bool Present { get; set; }
        public string? Remarks { get; set; }
    }
}
