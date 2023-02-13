using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts2_Giorgi
{
    internal class ContactManager
    {

        static List<Contact> contactList= new List<Contact>();


        public static void AddContact(Contact contact)
        { 
            contactList.Add(contact);
        }
        public static void RemoveContact(Contact contact)
        { contactList.Remove(contact); }

        public static void EditContact (Contact contact, string firstName, string lastName, int age, string phone, string email)
        {
            contact.FirsName= firstName;
            contact.LastName= lastName;
            contact.age= age;
            contact.Phone= phone;
            contact.Email= email;
        }

        public Contact View(int id)
        {
            return contactList[id];
        }
    }
}
