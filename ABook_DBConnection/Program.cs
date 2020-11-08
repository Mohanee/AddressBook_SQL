using System;

namespace ABook_DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddressBookRepo abrepo = new AddressBookRepo();
            //abrepo.RetrieveAllContacts();
            abrepo.UpdateContact();
        }
    }
}