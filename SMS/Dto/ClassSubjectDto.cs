namespace SMS.Dtos
{
    public class ClassSubjectDto
    {
            public int ClassSubjectId { get; set; }
            public SubjectDto subject { get; set;}
            public string Type { get; set;}
            public StaffDto Professor { get; set;}
            public int ScheduleStart { get; set;}
            public int ScheduleEnd { get; set;}
            public string SchoolSession { get; set;}
            public int ScheduleDay { get;}
            public string RecordList { get; set;}
            public List<StudentDto> students { get; set;}
            public int CurrentStudentCount { get; set;}
            public int MaxCapacity { get; set;}
    }
}
