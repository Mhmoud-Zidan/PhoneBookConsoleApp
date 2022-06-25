using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsole
{
    internal class PhoneBook
    {
        private List<Contact> _contacts = new List<Contact>();  
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            Console.WriteLine("Contact: {0} - {1} is Added ", contact.Name, contact.Number);
        }
        private void DiplayAllContactsDetails(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("Contact: {0} - {1} ", contact.Name, contact.Number);
            }
        }
        private void DiplayContactDetails(Contact contact)
        {
            Console.WriteLine("Contact: {0} - {1} ", contact.Name, contact.Number);
        }
        public void FindContactbyNum(string num)
        {
            Contact contact = _contacts.FirstOrDefault(c => c.Number == num);
            if (contact == null)
            {
                Console.WriteLine("not exist");
            }
            else
            {
                DiplayContactDetails(contact);
            }
        }
        public void FindContactbyName(string serchPhrase)
        {
            var matchContacts = _contacts.Where(c => c.Name.Contains(serchPhrase)).ToList();
            DiplayAllContactsDetails(matchContacts);

        }
        public void DiplayAllContacts()
        {
            DiplayAllContactsDetails(_contacts);
        }

    }
}
