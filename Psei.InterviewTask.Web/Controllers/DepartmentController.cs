using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Psei.InterviewTask.Web.Dto;
using Psei.InterviewTask.Web.Repository;

namespace Psei.InterviewTask.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        /// <summary>
        /// Returns list of Departments
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET api/v1/department
        /// </remarks>
        /// <returns>List of Departments</returns>
        /// <response code="200">Returns list of Departments</response>
        [HttpGet()]
        public async Task<ActionResult<IReadOnlyCollection<DepartmentDto>>> Get()
        {
            var result = await _departmentRepository.GetAll();

            return Ok(result);
        }
    }
}