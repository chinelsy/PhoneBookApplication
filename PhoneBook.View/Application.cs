using PhoneBook.Entities.Model;
using PhoneBook.Logic;
using System;

namespace PhoneBook.View
{
    public static class Application
    {
        public static void RunApplication()
        {
            try
            {
                var userInput = Console.ReadLine();
                var phoneContacts = new PhoneContacts();
                while (true)
                {
                    switch (userInput)
                    {
                        //Validation for Name and Number
                        case "1":
                            start:
                            var name = PhoneValidation.ConfirmNameValidation("name");
                            if (string.IsNullOrEmpty(name))
                                goto start;

                            begin:
                            var number = PhoneValidation.ValidatePhoneNumber("number");
                            if (string.IsNullOrEmpty(number))
                                goto begin;

                            var id = phoneContacts.GetLastContactById() + 1;
                            var newContact = new Contact
                            {
                                Name = name,
                                Number = number,
                                Id = id
                            };
                            phoneContacts.AddContact(newContact);
                            break;

                        case "2":
                            phoneContacts.GetAllContacts();
                            break;

                        case "3":
                            Console.WriteLine(" Contact number to Search");
                            var searchNumber = Console.ReadLine();
                            phoneContacts.DisplayContact(searchNumber);
                            break;

                        case "4":
                            Console.WriteLine("Contact to update with the id");
                           var contactId = Int32.Parse(Console.ReadLine());
                            phoneContacts.UpdateContact(contactId);
                            //var id = phoneContacts.UpdateContact(0);
                            break;

                        case "5":
                            Console.WriteLine("Search for Contact");
                            var searchPhrase = Console.ReadLine();
                            phoneContacts.DisplayMatchingContacts(searchPhrase);
                            break;

                        case "6":
                            Console.WriteLine("enter the contact name to delete");
                            var contact = Console.ReadLine();
                            phoneContacts.RemoveContact(contact);
                            Console.WriteLine("Deleted");
                            break;

                        case "x":
                            return;
                        default:
                            Console.WriteLine("Select valid operation");
                            break;

                    }
                    Console.WriteLine("Select Operation");
                    userInput = Console.ReadLine();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
