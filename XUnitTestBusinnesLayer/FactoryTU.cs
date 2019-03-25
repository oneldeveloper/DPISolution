using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DPI.Model;

namespace XUnitTestBusinnesLayer
{
    public class FactoryTU
    {
        [Fact]
        public void CreateFactory()
        {
            var factory = new Factory()
            {
                Id = 100;

            }
        }

    }

}
