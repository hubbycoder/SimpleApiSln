using SimpleApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using SimpleApi.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleApi.Test
{
    public class WFControllerTest
    {

        [Fact]
        public void GetValuesTest()
        {
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();
           
            var controller = new WeatherForecastController(mockLogger.Object);            
           
            var results = controller.Get().ToList();           

            Assert.Equal(5, results.Count());
        }
    }
}
