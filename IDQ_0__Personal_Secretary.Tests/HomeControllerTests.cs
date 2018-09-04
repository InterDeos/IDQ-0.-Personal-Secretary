using System;
using System.Collections.Generic;
using System.Text;
using IDQ_0__Personal_Secretary.Controllers;
using Xunit;

namespace IDQ_0__Personal_Secretary.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void HomeResult()
        {
            //Arrange
            HomeController home = new HomeController();

            // Act
            string result = home.Index();

            //Assert
            Assert.Equal("Index", result);
        }
    }
}
