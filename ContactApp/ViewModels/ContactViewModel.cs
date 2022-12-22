using ContactApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactApp.ViewModels
{
    internal class ContactViewModel
    {
        private static List<Contact> contacts = new List<Contact>()
        {
            new Contact { Id = 1, Name = "Agus", Phone = "081234567891" },
            new Contact { Id = 2, Name = "Budi", Phone = "081234567892" },
            new Contact { Id = 3, Name = "Citra", Phone = "081234567893" },
            new Contact { Id = 4, Name = "Dita", Phone = "081234567894" },
            new Contact { Id = 5, Name = "Ferdy", Phone = "081234567895" }
        };

        public static List<Contact> Contacts => contacts;

        private static int GetLastContactId()
        {
            if (contacts.Count == 0) return -1;
            return contacts[contacts.Count - 1].Id ?? -1;
        }

        public static void AddContact(Contact contact)
        {
            var lastContactId = GetLastContactId();
            contact.Id = lastContactId != -1 ? lastContactId + 1 : 1;
            contacts.Add(contact);
        }

        public static Contact GetContactById(int id)
        {
            return contacts.FirstOrDefault(x => x.Id == id);
        }

        public static void UpdateContact(Contact contact)
        {
            var contactIndex = contacts.FindIndex(x => x.Id == contact.Id);
            if (contactIndex != -1)
            {
                contacts[contactIndex] = contact;
            }
        }

        public static void RemoveContact(int id)
        {
            var contactIndex = contacts.FindIndex(x => x.Id == id);
            if (contactIndex != -1)
            {
                contacts.RemoveAt(contactIndex);
            }
        }
    }
}
