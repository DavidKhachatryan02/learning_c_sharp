using System.Text;
namespace _homework_7_task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter preferred Name:");
            string? preferredName = Console.ReadLine();

            Console.WriteLine("Enter nickname:");
            string? nickname = Console.ReadLine();

            Console.WriteLine("Enter username name:");
            string? username = Console.ReadLine();

            preferredName = string.IsNullOrEmpty(preferredName) ? null : preferredName;
            nickname = string.IsNullOrEmpty(nickname) ? null : nickname;
            username = string.IsNullOrEmpty(username) ? null : username;

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Preferred Name: {preferredName ?? "[empty]"}");
            result.AppendLine($"Nickname: {nickname ?? "[empty]"}");
            result.AppendLine($"username: {username ?? "[empty]"}");
            result.AppendLine($"Hello {preferredName ?? nickname ?? username ?? "Guest"}!"); 

            Console.WriteLine(result.ToString());
        }
    }
}