namespace SMS.Models
{
    public class Staff : UserExtend
    {
        public string StaffId { get; set; }
        public string School { get; set; }
        public string ClassInSchoolList { get; set; }
        public string ClassSubjectList { get; set; }
    }
}
