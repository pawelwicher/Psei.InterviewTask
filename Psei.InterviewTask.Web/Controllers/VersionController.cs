using Microsoft.AspNetCore.Mvc;

namespace Psei.InterviewTask.Web.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        /// <summary>
        /// Returns service version
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET api/v1/version
        /// </remarks>
        /// <returns>Service version</returns>
        /// <response code="200">Returns version of the service</response>
        [HttpGet()]
        public ActionResult<string> Get()
        {
            const string version = "1.0.0";

            return Ok(version);
        }
    }
}
