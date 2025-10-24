using Inheritance.Class;
using System.Text.RegularExpressions;

namespace Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        string userName = "";
        string passWord = "";
        string email = "";
        bool isSuperAdmin;
        string section;


        while (true) 
        {
            Console.WriteLine("Please,enter UserName");
            userName = Console.ReadLine();
            if (userName.Length > 5) break;
            Console.WriteLine("UserName must be greater than 6");
        }
        while (true)
        {
            Console.WriteLine("Please, enter passWord:");
            passWord = Console.ReadLine();
            if(passWord.Length>0)
            {
                if ((Regex.IsMatch(passWord, @"[A-Z]")))
                {
                    break;
                }
                else  Console.WriteLine("PassWord must be a letter "); 
            }
            Console.WriteLine("PassWord must be greater than 0");
        }

        Console.Write("If you want to enter an email, write it down or leave it blank. ");
        email = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(email))
        {
            while (!email.Contains("@") || Regex.IsMatch(email[0].ToString(), @"\W") ||  Regex.IsMatch(email[^1].ToString(), @"\W"))
            {
                Console.WriteLine("The email is not in the correct format. It must contain the '@' symbol and must not contain any special characters at the beginning/end.");
                Console.Write("Please, enter email ");
                email = Console.ReadLine();
            }
        }
        else
        {
            email = null;
        }

        
        Console.Write("IsSuperAdmin (true/false): ");
        while (!bool.TryParse(Console.ReadLine(), out isSuperAdmin))
        {
            Console.WriteLine(" Only enter 'true' or 'false'.");
            Console.Write("IsSuperAdmin (true/false): ");
        }

        Console.Write("Please enter Section:");
        while (true)
        {
            section = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(section))
                break;
            Console.WriteLine("Section in not empty");
        }

        Admin admin = new(userName, passWord, isSuperAdmin, section, email);
        admin.PrintInfo();
        Console.WriteLine("Finally admin");



    }
}
