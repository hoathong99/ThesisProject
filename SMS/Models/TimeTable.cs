using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class TimeTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeTableId { get; set; }
        public string OwnerId { get; set; }
        public string SchoolSession { get; set; }

    }
}
