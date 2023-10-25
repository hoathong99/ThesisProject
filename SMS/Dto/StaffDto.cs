namespace SMS.Dtos
{
    public class StaffDto : UserExtendDto
    {
        public string StaffId { get; set; }
        public string School { get; set; }
        public List<ClassInSchoolDto> ClassInSchoolList { get; set; }
        public List<ClassSubjectDto> ClassSubjectList { get; set; }
    }
}
