

using Inheritance.Class;

namespace Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        string username;
        string password;
        string email;
        bool isAdmin;
        string section;

        do
        {
            Console.WriteLine("Enter UserName:");
            username = Console.ReadLine();
        } while (User.CheckNamee(username) == false);

        do
        {
            Console.WriteLine("Enter passWord:");
            password = Console.ReadLine();
        }
        while (User.CheckPassworde(password) == false);


        Console.WriteLine("Do you want to email? (yes/no)");
        string chose = Console.ReadLine();
        if (chose == "yes")
        {
            while (true)
            {
                Console.WriteLine("Enter email:");
                email = Console.ReadLine();
                if (User.CheckEmail(email)) break;
                else Console.WriteLine("Try again.");
            }
        }
        else email = "";


        while (true)
        {
            Console.WriteLine("Are you userAdmin: (yes/no)");
            string choseAdmin = Console.ReadLine();
            if (choseAdmin == "yes")
            {
                isAdmin = true;
                break;
            }
            else if (choseAdmin == "no")
            {
                isAdmin = false;
                break;
            }
            else Console.WriteLine("Try again.");
        }

        while (true)
        {
            Console.WriteLine("Enter section:");
            section = Console.ReadLine();
            if (!string.IsNullOrEmpty(section))
            {
                break;
            }
            else Console.WriteLine("Try again");
        }


        Admin admin = new(username, password, isAdmin, section, email);
        Console.WriteLine("Admin create successfully");
        Console.WriteLine(admin.GetAdminInfo());
       
        


    }



}