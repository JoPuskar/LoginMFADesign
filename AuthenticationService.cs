using System;

class AuthenticationService
{
    public User AuthenticateUser()
    {
        Console.WriteLine("Welcome to the Console App Login!");

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        // Simulated authentication logic - replace with actual authentication logic
        if (username == "joshi" && password == "somepassword")
        {
            return new User { Username = username, Password = password };
        }
        else
        {
            return null;
        }
    }

    public bool AskUserForMfa()
    {
        Console.Write("Do you want to enable Multi-Factor Authentication? (yes/no): ");
        string choice = Console.ReadLine().ToLower();
        return choice == "yes";
    }
}

