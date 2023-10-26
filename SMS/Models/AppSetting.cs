using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Models
{
    public class AppSetting
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public bool IsEnrollSession { get; set; }
        public string CurrentSession { get; set; }
        public string EnrollSession { get; set; }
        public bool IsRegisterSession { get; set; }
        public int CurrentWeek { get; set; }
    }
}
