namespace SMS.Dtos
{
    public class TimeTableContentDto
    {
        public int TTContentId { get; set; }
        public string  TimeTableId { get; set; }
        public string SubjectName { get; set;}
        public string SubjectCode { get; set; }
        public string Type { get; set; }
        public int TimeFrame { get; set; }
        public int Day { get; set; }
        public string ClassRoom { get; set; }
        public string color { get; set; }
    }
}
