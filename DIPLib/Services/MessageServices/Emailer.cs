using System;

namespace DIPLib
{
    public class Emailer : IMessager
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending email to { person.EmailAddress }");
        }
    }
}