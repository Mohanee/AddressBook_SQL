using System;

namespace ABook_DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddressBookRepo aRepo = new AddressBookRepo();

         /*   //Retrieve all Contacts in AddressBook
            aRepo.RetrieveAllContacts();

            //Update a contact in AddressBook
            string updateQuery = @"update AddressInfo set State='T.L.' where FirstName='Mohanee';";
            aRepo.UpdateContact(updateQuery);
            string testQuery = @"select State from AddressInfo where FirstName='Mohanee';";
            Console.WriteLine(aRepo.RetrieveForTesting(testQuery));
         */
            //Delete Rows with selected DateRange
            string deleteQuery = @"delete from ABookTable where DateAdded between '2012-07-29' and '2013-06-29';";
            aRepo.DeleteRowsForSelectedDateRange(deleteQuery);

        }
    }
}