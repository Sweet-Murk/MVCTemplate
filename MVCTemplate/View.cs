using System;

namespace MVCTemplate
{
    public class View
    {
        public void printModelName(Model model)
        {
            Console.WriteLine(model.getName());
            Console.WriteLine(model.getNumber());
            Console.WriteLine(model.getFirstName());
            Console.WriteLine(model.getLastName());
            Console.WriteLine("-------------------------------");
        }
        public void printMainMenu()
        {
            Console.WriteLine("Hello, worker! Welcome to ur cabinet! Please, enter the data below in example format(name of book, serial number of book, first name and last name of human that takes a book):");
        }
    }
}
