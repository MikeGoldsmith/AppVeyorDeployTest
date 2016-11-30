using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppVeyorBuild;

namespace AppVeyorBuildTests
{
    public class LoggerTests
    {
        public void Test()
        {
            var logger = new Logger();
            logger.Log("test");
        }
    }
}
