using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class ClassSubject
    {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ClassSubjectId { get; set; }
            public string ClassSubjectCode { get; set;}
            public string Type { get; set;}
            public string Professor { get; set;}
            public int ScheduleStart { get; set;}
            public int ScheduleEnd { get; set;}
            public string SchoolSession { get; set;}
            public int ScheduleDay { get;}
            public string RecordList { get; set;}
            public string students { get; set;}
            public int CurrentStudentCount { get; set;}
            public int MaxCapacity { get; set;}
    }
}
