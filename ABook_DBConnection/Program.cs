using System;

namespace ABook_DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddressBookRepo aRepo = new AddressBookRepo();
            //abrepo.RetrieveAllContacts();
            //abrepo.UpdateContact();

            string updateQuery = @"update AddressInfo set State='T.L.' where FirstName='Mohanee';";
            aRepo.UpdateContact(updateQuery);
            string testQuery = @"select State from AddressInfo where FirstName='Mohanee';";
            Console.WriteLine(aRepo.RetrieveForTesting(testQuery));

        }
    }
}