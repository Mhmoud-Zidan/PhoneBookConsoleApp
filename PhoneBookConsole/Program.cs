using System;

namespace PhoneBookConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Operation");
            Console.WriteLine("1- Add Contact");
            Console.WriteLine("2- Display All Contacts");
            Console.WriteLine("3- Find by Name");
            Console.WriteLine("4- Find by Number");
            Console.WriteLine("press \"x\" to exit");


            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter a Name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter a Number");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("All Contacts: ");
                        phoneBook.DiplayAllContacts();
                        break;
                    case "3":
                        Console.WriteLine("Enter a Name");
                        string searchName = Console.ReadLine();
                        phoneBook.FindContactbyName(searchName);
                        break;
                    case "4":
                        Console.WriteLine("Enter a Number");
                        string searchNum = Console.ReadLine();
                        phoneBook.FindContactbyNum(searchNum);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Enter a Valid Number");
                        break;
                }
                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();

            }



        }
    }
}