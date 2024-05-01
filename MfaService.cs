using System;

class MfaService
{
    public string GenerateMfaCode()
    {
        Random random = new Random();
        int mfaNumber = random.Next(100000, 999999); // Generate a random 6-digit number
        return mfaNumber.ToString();
    }

    public bool PerformMultiFactorAuthentication(string expectedMfaCode)
    {
        Console.WriteLine("Multi-factor Authentication");

        Console.Write("Enter multi-factor authentication code: ");
        string mfaCode = Console.ReadLine();

        // Check if the entered code matches the expected code
        return mfaCode == expectedMfaCode;
    }
}

