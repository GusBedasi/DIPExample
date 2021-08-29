using System;

namespace DIPLib
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to console: { message }");
        }
    }
}