using ContactApp.Models;
using ContactApp.ViewModels;
using System;
using System.Collections.Generic;

namespace ContactApp.Views
{
    internal class ContactView
    {
        private void display()
        {
            List<Contact> contacts = ContactViewModel.Contacts;
            Console.Clear();
            Console.WriteLine("+=======================================+");
            Console.WriteLine("|             DATA CONTACTS             |");
            Console.WriteLine("+=======================================+");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"[{contact.Id}] {contact.Name} ({contact.Phone})");
            }
            Console.WriteLine("+=======================================+");
        }

        private Contact entryContact()
        {
            Console.Clear();
            string name, phone;
            Console.Write("Contact Name: ");
            name = Console.ReadLine();
            Console.Write("Phone Number: ");
            phone = Console.ReadLine();

            return new Contact { Name = name, Phone = phone };
        }

        private void createContact()
        {
            var newContact = entryContact();
            ContactViewModel.AddContact(newContact);
        }

        private void deleteContact()
        {
            display();
            Console.Write("Please select contact ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            ContactViewModel.RemoveContact(id);
        }
        
        private void updateContact() {
            display();
            Console.Write("Please select contact ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var newContact = entryContact();
            newContact.Id = id;
            ContactViewModel.UpdateContact(newContact);
        }

        public void run()
        {
            int choice;
            do
            {
                display();

                Console.WriteLine("|               MAIN MENU               |");
                Console.WriteLine("+===+===================================+");
                Console.WriteLine("| 1 | Add New Contact                   |");
                Console.WriteLine("| 2 | Update Contact                    |");
                Console.WriteLine("| 3 | Delete Contact                    |");
                Console.WriteLine("| 0 | Exit                              |");
                Console.WriteLine("+===+===================================+");
                Console.Write("Please insert your choice (1...4) : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        createContact();
                        break;
                    case 2:
                        updateContact();
                        break;
                    case 3:                        
                        deleteContact();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Thank you for using this app...");
                        Console.ReadKey();
                        break;
                    default: 
                        Console.Clear(); 
                        Console.WriteLine("Invalid choice, please try again...");
                        Console.ReadKey(true);
                        break;
                }
            } while (choice != 0);
        }
    }
}
