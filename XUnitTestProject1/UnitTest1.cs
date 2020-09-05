using Moq;
using System;
using WebApplication18.Models;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly Mock<IApplicationUserRepository> _mockRepo;
        private readonly EmployeesController _controller;
        public UnitTest1()
        {
            _mockRepo = new Mock<IEmployeeRepository>();
            _controller = new EmployeesController(_mockRepo.Object);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
