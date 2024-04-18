namespace library_management.src.Entity
{
    public interface INotificationService
    {
        void SendNotificationOnSucess(string message);
        void SendNotificationOnFailure(string message);
    }
}