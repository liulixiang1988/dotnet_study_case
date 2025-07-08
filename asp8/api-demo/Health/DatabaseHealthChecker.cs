using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace api_demo.Health;

public class DatabaseHealthChecker(ILogger<DatabaseHealthChecker> logger): IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
    {
        // Simulate a database check
        bool isDatabaseHealthy = true; // Replace with actual database health check logic

        if (isDatabaseHealthy)
        {
            logger.LogInformation("Database health check passed.");
            return Task.FromResult(HealthCheckResult.Healthy("Database is healthy."));
        }
        else
        {
            logger.LogError("Database health check failed.");
            return Task.FromResult(HealthCheckResult.Unhealthy("Database is unhealthy."));
        }
    }
}