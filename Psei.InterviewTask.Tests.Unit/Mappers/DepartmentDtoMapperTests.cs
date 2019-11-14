using FluentAssertions;
using Psei.InterviewTask.Web.Dto;
using Psei.InterviewTask.Web.Mappers;
using Psei.InterviewTask.Web.Model;
using Xunit;

namespace Psei.InterviewTask.Tests.Unit.Mappers
{
    public class DepartmentDtoMapperTests
    {
        [Fact]
        public void Map_Should_ReturnProperResult()
        {
            var mapper = new DepartmentDtoMapper();

            var model = new Department
            {
                Id = 1,
                Name = "Foo"
            };

            var actual = mapper.Map(model);
            var expected = new DepartmentDto
            {
                Id = 1,
                Name = "Foo",
                FullName = "Departament of Foo"
            };

            actual.Should().BeEquivalentTo(expected);
        }
    }
}