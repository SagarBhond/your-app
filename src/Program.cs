var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Root endpoint
app.MapGet("/", () => "Hello from IIS deployed app!");

// Health check endpoint (VERY IMPORTANT)
app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run();
