using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMS.Data;
using SMS.Dtos;
using SMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace SMS.Services
{
    public class StudentServices
    {
        private readonly SMSContext _context;
        public StudentServices(SMSContext context) { _context = context; }

        private MapperConfiguration configToDto = new MapperConfiguration(cfg =>
            cfg.CreateMap<Student, StudentDto>().ForMember(des => des.RecordLst, opt => opt.Ignore())
        );

        private MapperConfiguration configFromDto = new MapperConfiguration(cfg =>
            cfg.CreateMap<StudentDto, Student>().ForMember(des => des.RecordLst, opt => opt.Ignore())
        );

    }
}
