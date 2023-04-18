namespace Nottern;

public class NotificationContext : INotificationContext
{
    private readonly List<Notification> _notifications = new();
    
    public IReadOnlyList<Notification> Notifications => _notifications;
    public bool HasNotifications => _notifications.Any();
    
    public void Add(string code, string message)
    {
        _notifications.Add(new (code, message));
    }
    
    public void Add(Notification notification)
    {
        _notifications.Add(notification);
    }
    
    public void AddRange(IEnumerable<Notification> notifications)
    {
        _notifications.AddRange(notifications);
    }
}
