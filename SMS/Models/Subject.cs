using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class Subject
    {
        [Key]
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Credit { get; set; }
    }
}
