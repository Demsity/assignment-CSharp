using ConsoleApp.Models;
using ConsoleApp.Services;

namespace ConsoleApp.Tests
{
    public class ContactTests
    {
        private ContactService contactService;
        private Contact testContact;
        private string filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Console.json";

        public ContactTests()
        {
            contactService = new ContactService();
           
           testContact = new Contact()
           {
               FirstName= "Test",
               LastName= "Test",
               Email= "Test",
               PhoneNumber= "Test",
               StreetName= "Test",
               City= "Test",
               PostalCode= "Test",
           };

        }
        

        [Fact]
        public void Should_Add_Contact_To_List()
        {
            contactService.AddContactToList(testContact, filePath);
            Assert.Single<Contact>(contactService.ContactList);
            File.Delete(filePath);
        }
    }
}