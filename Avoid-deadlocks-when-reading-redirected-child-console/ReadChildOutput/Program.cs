using System;
using System.Diagnostics;
using System.Text;

namespace ChildConsoleDeadlock
{
    public class Program
    {
        private static string ChildParam = "-child";

        public static int Main(string[] args)
        {
            if (args.Length == 1 && args[0] == ChildParam)
            {
                return BeChild();
            }

            return BeParent();
        }

        private static int BeChild()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("This is text that will be written 1000 times.");
                Console.Error.WriteLine("Error text written 1000 times.");
            }

            return 0;
        }

        private static int BeParent()
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = Environment.CommandLine.Replace(".vshost", string.Empty),
                Arguments = ChildParam,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (var process = Process.Start(processInfo))
            {
                var output = new StringBuilder();
                var error = new StringBuilder();

                process.OutputDataReceived += (sender, eventArgs) => output.AppendLine(eventArgs.Data);
                process.ErrorDataReceived += (sender, eventArgs) => error.AppendLine(eventArgs.Data);

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                Console.WriteLine("OUTPUT stream: " + output);
                Console.WriteLine("ERROR stream: " + error);
            }

            return 0;
        }
    }
}
