namespace DIPLib
{
    public interface IChore
    {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }
        void PerformedWork(double hours);
        void CompleteChore();
    }
}