using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Models
{
    public class StudentRecord
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }
        public string ClassSubjectId { get; set; }
        public string StudentId { get; set;}
        public double? Mark
        {
            get { return Mark; }
            set
            {
                if (value != Mark)
                {
                    Mark = value;
                    SetGrade();
                }
            }
        }
        public string? Grade { get; private set; }


        private void SetGrade()
        {
            switch (Mark)
            {
                case var m when m >= 9:
                    Grade = "A+";
                    break;
                case var m when m < 9 && m >= 8.5:
                    Grade = "A";
                    break;
                case var m when m < 8.5 && m >= 8:
                    Grade = "B+";
                    break;
                case var m when m < 8 && m >= 7:
                    Grade = "B";
                    break;
                case var m when m < 7 && m >= 5.5:
                    Grade = "C+";
                    break;
                case var m when m < 6.5 && m >= 5.5:
                    Grade = "C";    
                    break;
                case var m when m < 5.5 && m >= 5:
                    Grade = "D+";
                    break;
                case var m when m < 5 && m >= 4:
                    Grade = "D";
                    break;
                default:
                    Grade = "F";
                    break;
            }
        }
    }
}
