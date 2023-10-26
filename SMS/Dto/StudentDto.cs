namespace SMS.Dtos
{
    public class StudentDto: UserExtendDto
    {
        public int StudentId { get; set; }
        public double? CPA { get; set; }
        public int? PassCredit { get; set;}
        public int? TotalCredit { get; set; }
        public int? AcademicYear { get; set; }
        public List<StudentRecordDto>? RecordLst { get; set; }
    }
}
