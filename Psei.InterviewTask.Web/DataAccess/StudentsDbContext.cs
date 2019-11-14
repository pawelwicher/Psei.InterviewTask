using Microsoft.EntityFrameworkCore;
using Psei.InterviewTask.Web.Model;

namespace Psei.InterviewTask.Web.DataAccess
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
    }
}