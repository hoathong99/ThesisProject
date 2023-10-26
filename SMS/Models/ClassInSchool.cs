using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class ClassInSchool
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Monitor { get; set; }
        public string StaffInCharge { get; set; }
        public string Students { get; set; }
    }
}
