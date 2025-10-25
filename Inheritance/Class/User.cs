namespace Inheritance.Class;

internal class User
{
    public string UserName;
    public string Password;
    public string Email;


    public User(string userName, string password, string email = "")
    {
        UserName = userName;
        Password = password;
        Email = email;
    }
    public static bool CheckNamee(string userName)
    {
        if (userName.Length > 6 && !(string.IsNullOrWhiteSpace(userName)))
        {
            return true;
        }
        return false;
    }

    public static bool CheckPassworde(string password)
    {
        bool digit = false;
        bool upLetter = false;
        foreach (var p in password)
        {
            if (char.IsUpper(p)) upLetter = true;

            if (char.IsDigit(p)) digit = true;

            if (string.IsNullOrWhiteSpace(password)) return false;
        }
        return digit && upLetter;
    }

    public static bool CheckEmail(string email)
    {
        if (email.Contains("@") && !char.IsPunctuation(email[0]) && !char.IsPunctuation(email[email.Length - 1]))
        {
            return true;
        }
        return false;
    }












}
