using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMS.Data;
using SMS.Dtos;
using SMS.Models;

namespace SMS.Services
{
    public class StudentRecordServices
    {
        private readonly SMSContext _context;
        public StudentRecordServices(SMSContext context) { _context = context;  }

        private MapperConfiguration configToDto = new MapperConfiguration(cfg =>
            cfg.CreateMap<StudentRecord, StudentRecordDto>().ForMember(des => des.ClassSubject, opt => opt.Ignore())
);

        //private MapperConfiguration configFromDto = new MapperConfiguration(cfg =>
        //    cfg.CreateMap<StudentRecordDto, StudentRecord>().ForMember(des => des.ClassSubjectId, opt => opt.MapFrom(src => src.ClassSubject.ClassSubjectId))
        //);

        public List<StudentRecordDto> FindStudentRecord(string UID)
        {
            if (_context.Subject == null)
            {
                return null;
            }
            var data = _context.StudentRecords
            .Where(record => record.StudentId == UID)
            .ToList();

            var rs = new Mapper(configToDto).Map<List<StudentRecordDto>>(data);
            return rs;
        }

        public List<StudentRecordDto> FindStudentRecordWithSession(string UID, string Session)
        {
            if (_context.Subject == null)
            {
                return null;
            }


            return null;
        }
    }
}
