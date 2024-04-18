namespace library_management.src
{
    public interface INotificationService
    {
        void SendNotificationOnSucess(string message);
        void SendNotificationOnFailure(string message);
    }
}