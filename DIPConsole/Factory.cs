using DIPLib;

namespace DIPConsole
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMailer());
        }

        private static ILogger CreateLogger()
        {
            return new Logger();
        }

        private static IMessager CreateMailer()
        {
            return new SMSMessager(); // or new Emailer
        }
    }
}