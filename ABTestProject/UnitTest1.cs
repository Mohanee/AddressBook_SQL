using NUnit.Framework;
using ABook_DBConnection;

namespace ABTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenUpdateStatement_ShouldCheck_UpdatedRow()
        {
            AddressBookRepo aRepo = new AddressBookRepo();

            string updateQuery = @"update AddressInfo set State='T.L.' where FirstName='Mohanee';";
            aRepo.UpdateContact(updateQuery);
            string testQuery = @"select State from AddressInfo where FirstName='Mohanee';";
            string expectedData = aRepo.RetrieveForTesting(testQuery);
            string actualData = "T.L,";
            Assert.AreEqual(actualData,expectedData);
        }
    }
}