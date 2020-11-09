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
         
            //Delete Rows with selected DateRange
            string deleteQuery = @"delete from ABookTable where DateAdded between '2012-07-29' and '2013-06-29';";
            aRepo.DeleteRowsForSelectedDateRange(deleteQuery);*/

            //Addnew Contact
            ContactsModel contact = new ContactsModel();
            contact.FirstName = "Ritwick";
            contact.LastName = "Sharma";
            contact.Address = "Lajpat Colony";
            contact.City = "Delhi";
            contact.State = "Chandigarh";
            contact.Zipcode = "490087";
            contact.PhoneNumber = "23456789";
            contact.DateAdded = Convert.ToDateTime("2015-03-30");
            contact.Email = "ritwick@yahoo.com";
            contact.RelationType = "Friend";
            aRepo.AddContact(contact);

        }
    }
}