namespace DIPLib
{
    public interface IMessager
    {
        void SendEmail(IPerson person, string message);
    }
}