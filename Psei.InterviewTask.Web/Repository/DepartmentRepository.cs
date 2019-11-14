using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Psei.InterviewTask.Web.DataAccess;
using Psei.InterviewTask.Web.Dto;
using Psei.InterviewTask.Web.Mappers;

namespace Psei.InterviewTask.Web.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly StudentsDbContext _context;
        private readonly IDepartmentDtoMapper _mapper;

        public DepartmentRepository(StudentsDbContext context, IDepartmentDtoMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyCollection<DepartmentDto>> GetAll()
        {
            var models = await _context.Departments.ToListAsync();

            return models.Select(_mapper.Map).ToList().AsReadOnly();
        }
    }
}