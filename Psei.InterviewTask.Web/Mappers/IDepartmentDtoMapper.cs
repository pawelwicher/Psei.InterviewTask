using Psei.InterviewTask.Web.Dto;
using Psei.InterviewTask.Web.Model;

namespace Psei.InterviewTask.Web.Mappers
{
    public interface IDepartmentDtoMapper
    {
        DepartmentDto Map(Department model);
    }
}