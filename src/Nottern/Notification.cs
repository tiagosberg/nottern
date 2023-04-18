namespace Nottern;

public class Notification
{
    public string Code { get; init; }
    public string Message { get; init; }
    
    public Notification(string code, string message)
    {
        Code = code;
        Message = message;
    }
}
