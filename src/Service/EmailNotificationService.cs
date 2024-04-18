namespace library_management.src
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnSucess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Email Notification: {message}. If you have any queries or feedback, please contact our support team at support@library.com.");
        }
        public void SendNotificationOnFailure(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Email Notification: {message}. If you have any queries or feedback, please contact our support team at support@library.com.");
        }

    }
}