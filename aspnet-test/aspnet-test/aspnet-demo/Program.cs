using aspnet_demo.Filters;
using aspnet_demo.Middlewares;
using OpenTelemetry.Metrics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<BillFilter>();
    options.Filters.Add<RouteDemoFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenTelemetry().WithMetrics(meterProviderBuilder => meterProviderBuilder
    .AddPrometheusExporter());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseOpenTelemetryPrometheusScrapingEndpoint(
    // context => context.Request.Path == "/internal/metrics"
    //            && context.Connection.LocalPort == 5067
               );
// app.UseHttpsRedirection();
//app.UseExceptionHandler("/error");
app.UseMiddleware<RouteDemoMiddleware>();
app.UseAuthorization();

app.MapControllers();

var lifetime = app.Services.GetRequiredService<IHostApplicationLifetime>();
lifetime.ApplicationStarted.Register(() => { Console.WriteLine("Started"); });
lifetime.ApplicationStopping.Register(() => { Console.WriteLine("Stopping"); });
app.Run();