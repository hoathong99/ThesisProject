namespace SMS.Models
{
    public class Student : UserExtend
    {
        public int StudentId { get; set; }
        public double? CPA { get; set; }
        public int? PassCredit { get; set;}
        public int? TotalCredit { get; set; }
        public int? AcademicYear { get; set; }
        public string? RecordLst { get; set; }
    }
}
