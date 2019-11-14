using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Psei.InterviewTask.Web.DataAccess;
using Psei.InterviewTask.Web.Model;

namespace Psei.InterviewTask.Web.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly StudentsDbContext _context;

        public DepartmentRepository(StudentsDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<Department>> GetAll()
        {
            var models = await _context.Departments.ToListAsync();

            return models.AsReadOnly();
        }
    }
}