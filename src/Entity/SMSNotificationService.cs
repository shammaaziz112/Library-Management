namespace library_management.src.Entity
{
    public class SMSNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"SMS Notification: {message}");
        }

        public void SendNotificationOnSucess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
}