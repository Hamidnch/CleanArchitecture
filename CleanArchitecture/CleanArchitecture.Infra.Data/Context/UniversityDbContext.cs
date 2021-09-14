using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data.Context
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options): base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
