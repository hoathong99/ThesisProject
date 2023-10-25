using System;
using System.Collections.Generic;
using System.Linq;
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

        public DbSet<SMS.Models.Subject> Subject { get; set; } = default!;
    }
}
