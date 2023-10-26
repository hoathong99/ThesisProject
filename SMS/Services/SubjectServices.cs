using SMS.Data;
using SMS.Dtos;
using AutoMapper;
using SMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SMS.Services.Services
{
    public class SubjectServices
    {
        private readonly SMSContext _context;
        public SubjectServices(SMSContext context) { _context = context; }

        private MapperConfiguration configToDto = new MapperConfiguration(cfg =>
                    cfg.CreateMap<Subject, SubjectDto>()
        );

        private MapperConfiguration configFromDto = new MapperConfiguration(cfg =>
            cfg.CreateMap<SubjectDto, Subject>()
        );

        public async Task<SubjectDto> GetSubject(string subjectCode) {
            var subject = await _context.Subject.FindAsync(subjectCode);
            var rs = new Mapper(configToDto).Map<SubjectDto>(subject);

            return rs;
        }

        public async Task<ActionResult<IEnumerable<SubjectDto>>> GetAllSubject()
        {
            if (_context.Subject == null)
            {
                return null;
            }

            var data = await _context.Subject.ToListAsync();
            var rs = new Mapper(configToDto).Map<List<SubjectDto>>(data);
            return rs;
        }

        public async Task<bool> PostSubject(SubjectDto subject)
        {
            var data = new Mapper(configFromDto).Map<Subject>(subject);
            if (_context.Subject == null)
            {
                return false;
            }
            _context.Subject.Add(data);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SubjectExists(subject.SubjectCode))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            
            return true;
        }

        public async Task<Boolean> UpdateSubject(string id, SubjectDto subject)
        {
            var data = new Mapper(configFromDto).Map<Subject>(subject);
            if (id != subject.SubjectCode)
            {
                return false;
            }

            _context.Entry(data).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return true;
        }

        public async Task<bool> DeleteSubjectAsync(string subjectCode)
        {
            if (_context.Subject == null)
            {
                return false;
            }
            var subject = await _context.Subject.FindAsync(subjectCode);
            if (subject == null)
            {
                return false;
            }

            _context.Subject.Remove(subject);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool SubjectExists(string id)
        {
            return (_context.Subject?.Any(e => e.SubjectCode == id)).GetValueOrDefault();
        }

    }
}
