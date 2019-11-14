using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Psei.InterviewTask.Web.Controllers;
using Xunit;

namespace Psei.InterviewTask.Tests.Unit.Controllers
{
    public class VersionControllerTests
    {
        [Fact]
        public void Get_Always_ReturnsNonEmptyVersion()
        {
            var controller = CreateController();

            var result = controller.Get();

            result.Result.Should().BeOfType<OkObjectResult>();
        }

        private VersionController CreateController()
        {
            return new VersionController();
        }
    }
}