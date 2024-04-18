namespace library_management.src
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnSucess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Email Notification: {message}");
        }
        public void SendNotificationOnFailure(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Email Notification: {message}");
        }

    }
}