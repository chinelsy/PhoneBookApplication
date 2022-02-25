using PhoneBook.Configuration;
using PhoneBook.Entities.Model;
using PhoneBook.Logic;
using PhoneBook.Repository;
using System;

namespace PhoneBook.View
{

    public class Application
    {
        private readonly IEntryContact<Contact> _contact;
        private readonly IPhoneContactRepo<Contact> _contactRepo;
        public Application(IEntryContact<Contact> contact, IPhoneContactRepo<Contact> contactRepo)
        {
            _contact = contact;
            _contactRepo = contactRepo;
        }
        public void RunApplication()
        {
            try
            {
                var userInput = Console.ReadLine();
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

                            var id = _contact.GetLastContactById() + 1;
                            var newContact = new Contact
                            {
                                Name = name,
                                Number = number,
                                Id = id
                            };
                            var result = SeedData.IsDuplicate(name, number);
                           if (!result)
                                _contact.AddContact(newContact);


                                break;

                        case "2":
                            _contact.GetAllContacts();
                            break;

                        case "3":
                            Console.WriteLine(" Contact number to Search");
                            var searchNumber = Console.ReadLine();

                            _contactRepo.DisplayContact(searchNumber);
                            break;

                        case "4":
                            Console.WriteLine("Contact to update with the id");
                            var contactId = Int32.Parse(Console.ReadLine());
                            _contact.UpdateContact(contactId);
                            break;

                        case "5":
                            Console.WriteLine("Search for Contact");
                            var searchPhrase = Console.ReadLine();
                            _contactRepo.DisplayMatchingContacts(searchPhrase);
                            break;

                        case "6":
                            Console.WriteLine("enter the contact name to delete");
                            var contact = Console.ReadLine();
                            _contact.RemoveContact(contact);
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
