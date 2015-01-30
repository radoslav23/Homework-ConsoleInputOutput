/*A company has name, address, phone number, fax number, web site and manager. 
The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company 
and its manager and prints it back on the console.*/
using System;

class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine(companyName);

            Console.Write("Enter company adress: ");
            string companyAdress = Console.ReadLine();
            Console.WriteLine("Adress: {0}", companyAdress);

            Console.Write("Enter company phone number: ");
            long companyPhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Tel. {0}", companyPhoneNumber);

            Console.Write("Enter company fax number: ");
            long companyFaxNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Fax: (no fax)");

            Console.Write("Enter company Web site: ");
            string companyWebCite = Console.ReadLine();
            Console.WriteLine("Web site: {0}", companyWebCite);

            Console.Write("Enter manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Enter manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Enter manager age: ");
            int managerAge = int.Parse(Console.ReadLine());

            Console.Write("Enter manager phone number: ");
            long managerPhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Manager: {0} (age: {1}, tel. {2})",
                 managerFirstName + " " + managerLastName, managerAge, managerPhoneNumber);
        }
    }

