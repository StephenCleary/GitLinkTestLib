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
        public static void SynchronousMethod()
        {
            var dir = Environment.CurrentDirectory;
            Trace.WriteLine("Hi, I'm at: " + dir);
        }

        public static async Task AsynchronousMethod()
        {
            var dir = Environment.CurrentDirectory;
            Trace.WriteLine("Hi, I'm at: " + dir);
            await Task.Yield();
        }

        public static Task TaskReturningSynchronousMethod()
        {
            var dir = Environment.CurrentDirectory;
            Trace.WriteLine("Hi, I'm at: " + dir);
            return Task.CompletedTask;
        }
    }
}
