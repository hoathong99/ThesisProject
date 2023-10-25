namespace SMS.Dtos
{
    public class ClassInSchoolDto
    {
        public StudentDto Monitor { get; set; }
        public StaffDto StaffInCharge { get; set; }
        public List<StudentDto> Students { get; set; }
    }
}
