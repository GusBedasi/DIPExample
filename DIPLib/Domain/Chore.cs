namespace DIPLib
{
    public class Chore : IChore
    {
        private readonly ILogger _logger;
        private readonly IMessager _mailer;
        public Chore(ILogger logger, IMessager mailer)
        {
            _logger = logger;
            _mailer = mailer;
        }
        
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed { ChoreName }");
            _mailer.SendEmail(Owner, $"The chore {ChoreName} is completed.");
        }
    }
}