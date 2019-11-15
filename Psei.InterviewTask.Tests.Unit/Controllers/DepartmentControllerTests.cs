using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Psei.InterviewTask.Web.Controllers;
using Psei.InterviewTask.Web.Dto;
using Psei.InterviewTask.Web.Model;
using Psei.InterviewTask.Web.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Psei.InterviewTask.Tests.Unit.Controllers
{
    public class DepartmentControllerTests
    {
        [Fact]
        public void Get_Should_ReturnProperResult()
        {
            var controller = CreateController();

            var result = controller.Get();

            result.Result.Should().BeOfType<ActionResult<IReadOnlyCollection<DepartmentDto>>>();
        }

        private DepartmentController CreateController()
        {
            var repo = Substitute.For<IDepartmentRepository>();
            repo.GetAll().Returns(Task.FromResult(new[] { new Department() }).GetAwaiter().GetResult());

            return new DepartmentController(repo);
        }
    }
}