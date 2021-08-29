using System;
using DIPLib;

namespace DIPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Gustavo";
            owner.LastName = "Melo";
            owner.EmailAddress = "gustavo@gmail.com";
            owner.PhoneNumber = "99999-9999";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
