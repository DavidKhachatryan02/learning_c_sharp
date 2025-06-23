namespace _homework_9_task_4
{
    public struct EmailValidator
    {
        public string Email;

        public EmailValidator(string email)
        {
            Email = email;
        }

        public bool IsValidEmail()
        {
            return Email.Contains('@') && Email.Contains('.');
        }

        public void PrintValidation()
        {
            if (IsValidEmail())
                Console.WriteLine($"Email \"{Email}\" is valid.");
            else
                Console.WriteLine($"Email \"{Email}\" is invalid.");
        }
    }

    class Program
    {
        static void Main()
        {
            EmailValidator e1 = new EmailValidator("user@example.com");
            EmailValidator e2 = new EmailValidator("invalid-email");

            e1.PrintValidation();
            e2.PrintValidation();
        }
    }
}
