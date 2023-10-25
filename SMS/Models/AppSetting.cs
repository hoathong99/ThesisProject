namespace SMS.Models
{
    public class AppSetting
    {
        public bool IsEnrollSession { get; set; }
        public string CurrentSession { get; set; }
        public string EnrollSession { get; set; }
        public bool IsRegisterSession { get; set; }
        public int CurrentWeek { get; set; }
    }
}
