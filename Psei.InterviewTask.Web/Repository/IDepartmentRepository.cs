using System.Collections.Generic;
using System.Threading.Tasks;
using Psei.InterviewTask.Web.Dto;

namespace Psei.InterviewTask.Web.Repository
{
    public interface IDepartmentRepository
    {
        Task<IReadOnlyCollection<DepartmentDto>> GetAll();
    }
}