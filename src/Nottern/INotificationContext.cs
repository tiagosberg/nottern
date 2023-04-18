namespace Nottern;

public interface INotificationContext
{
    IReadOnlyList<Notification> Notifications { get; }
    bool HasNotifications { get; }

    void Add(string code, string message);
    void Add(Notification notification);
    void AddRange(IEnumerable<Notification> notifications);
}
