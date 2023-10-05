using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace Schedule;

public static class DepedencyInjection
{
    public static void AddScheduler(this IServiceCollection services)
    {
        services.AddQuartz();

        services.AddQuartzHostedService(options =>
        {
            options.WaitForJobsToComplete = true;
        });

        services.ConfigureOptions<LoggingBackgroundJobSetup>();
    }
}

