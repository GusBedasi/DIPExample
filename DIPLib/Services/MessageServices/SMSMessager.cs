using System;

namespace DIPLib
{
    public class SMSMessager: IMessager
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending SMS to { person.PhoneNumber }");
        }
    }
}