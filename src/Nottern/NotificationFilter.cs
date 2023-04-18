using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Nottern;

public class NotificationFilter : IAsyncResultFilter
{
    private readonly INotificationContext _notificationContext;

    public NotificationFilter(INotificationContext notificationContext)
    {
        _notificationContext = notificationContext;
    }
    
    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        if (_notificationContext.HasNotifications)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.HttpContext.Response.ContentType = "application/json";

            var notifications = JsonSerializer.Serialize(_notificationContext.Notifications);
            await context.HttpContext.Response.WriteAsync(notifications);

            return;
        }
        
        await next();
    }
}
