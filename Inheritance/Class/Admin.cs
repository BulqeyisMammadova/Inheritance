namespace Inheritance.Class;

internal class Admin : User
{
    public bool IsSuperAdmin;
    public string Section;

    public Admin(string name, string password, bool isadmin, string section, string email = "") : base(name, password)
    {
        if (!string.IsNullOrWhiteSpace(section))
        {
            Section = section;
        }
        else
        {
            Console.WriteLine("Section can not empty.");
            IsSuperAdmin = isadmin;
        }
    }

    public string GetAdminInfo()
    {
        return $"Username: {UserName}\n" + $"PassWord:{Password}\n" + $"Email: {(string.IsNullOrEmpty(Email) ? "Is not Email" : Email)}\n" + $"IsSuperAdmin: {IsSuperAdmin}\n" + $"Section: {Section}";
    }

}
