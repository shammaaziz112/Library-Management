namespace library_management.src.Entity
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Email Notification: {message}");
        }

        public void SendNotificationOnSucess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Email Notification: {message}");
        }
    }
}