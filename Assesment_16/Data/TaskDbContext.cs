using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assesment_16.Models;

namespace Assesment_16.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext (DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assesment_16.Models.Tasks> Tasks { get; set; } = default!;
    }
}
