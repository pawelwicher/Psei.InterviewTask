using Psei.InterviewTask.Web.Dto;
using Psei.InterviewTask.Web.Model;

namespace Psei.InterviewTask.Web.Mappers
{
    public class DepartmentDtoMapper : IDepartmentDtoMapper
    {
        public DepartmentDto Map(Department model)
        {
            return new DepartmentDto
            {
                Id = model.Id,
                Name = model.Name,
                FullName = $"Departament of {model.Name}"
            };
        }
    }
}