using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLinkTestLib
{
    public static class Test
    {
        public static void StepIntoMe()
        {
            var dir = Environment.CurrentDirectory;
            Trace.WriteLine("Hi, I'm at: " + dir);
        }
    }
}
