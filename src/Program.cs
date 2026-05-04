var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Home endpoint
app.MapGet("/", () => "🚀 Hello Sagar! IIS Deployment Successful");

// Health endpoint (IMPORTANT for pipeline)
app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run();
