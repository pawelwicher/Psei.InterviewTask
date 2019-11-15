using System.Collections.Generic;
using System.Threading.Tasks;
using Psei.InterviewTask.Web.Model;

namespace Psei.InterviewTask.Web.Repository
{
    public interface IDepartmentRepository
    {
        Task<IReadOnlyCollection<Department>> GetAll();
    }
}