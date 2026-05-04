var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from IIS Deployment");
app.MapGet("/health", () => "Healthy");

app.Run();
