using DPI.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestBusinnesLayer
{
    public class DPITestUnit
    {

        [Fact]
        void TestFactory()
        {
            var factory = new Factory()
            {
                Id = 10,
                Name = "Onel"

            };

        }
    }
}
