using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Nottern;

public static class NotificationExtensions
{
    public static void AddNotification(this IServiceCollection services)
    {
        services.Configure<MvcOptions>(options =>
        {
            options.Filters.Add<NotificationFilter>();
        });
        
        services.AddScoped<INotificationContext, NotificationContext>();
    }
}
