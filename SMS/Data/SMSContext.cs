using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SMS.Models;

namespace SMS.Data
{
    public class SMSContext : DbContext
    {
        public SMSContext (DbContextOptions<SMSContext> options)
            : base(options)
        {
        }


        public DbSet<SMS.Models.AppSetting> AppSettings { get; set; } = default!;
        public DbSet<SMS.Models.ClassSubject> ClassSubjects { get; set; } = default!;
        public DbSet<SMS.Models.ClassInSchool> ClassInSchools { get; set; } = default!;
        public DbSet<SMS.Models.Staff> Staffs { get; set; } = default!;
        public DbSet<SMS.Models.Student> Students { get; set; } = default!;
        public DbSet<SMS.Models.StudentRecord> StudentRecords { get; set; } = default!;
        public DbSet<SMS.Models.Subject> Subject { get; set; } = default!;
        public DbSet<SMS.Models.TimeTable> TimeTables { get; set; } = default!;
        public DbSet<SMS.Models.TimeTableContent> TimeTableContents { get; set; } = default!;
        public DbSet<SMS.Models.UserExtend> UserExtends { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
