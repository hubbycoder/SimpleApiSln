using System;
using Xunit;
using SimpleApi.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace SimpleApi.Test
{
    public class ValueControllerTest
    {

        ValuesController controller = new();

        [Fact]
        public void GetValuesTest()
        {
            IEnumerable<string> results = controller.Get().ToList();
            
            Assert.Equal(2, results.Count());
        }

        [Fact]
        public void GetValueByIdTest()
        {
            var result = controller.Get(1);
            Assert.Equal("value", result);
        }
    }
}
