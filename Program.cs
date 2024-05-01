using System;

class Program
{
    static void Main(string[] args)
    {
        AuthenticationService authService = new AuthenticationService();
        User user = authService.AuthenticateUser();

        if (user != null)
        {
            bool enableMfa = authService.AskUserForMfa();

            if (enableMfa)
            {
                MfaService mfaService = new MfaService();
                string mfaCode = mfaService.GenerateMfaCode();
                Console.WriteLine($"Multi-factor Authentication Code: {mfaCode}");

                if (mfaService.PerformMultiFactorAuthentication(mfaCode))
                {
                    Console.WriteLine("Login successful!");
                    // Proceed with application logic
                }
                else
                {
                    Console.WriteLine("Multi-factor authentication failed.");
                }
            }
            else
            {
                Console.WriteLine("Proceeding with regular authentication...");
                // Proceed with application logic without MFA
            }
        }
        else
        {
            Console.WriteLine("Authentication failed.");
        }
    }
}

