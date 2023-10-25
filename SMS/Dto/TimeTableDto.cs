namespace SMS.Dtos
{
    public class TimeTableDto
    {
        public int TimeTableId { get; set; }
        public string OwnerId { get; set; }
        public string SchoolSession { get; set; }
        public List<TimeTableContentDto> Contents { get; set; }
    }
}
