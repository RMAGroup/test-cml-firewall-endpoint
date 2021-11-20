var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "RMA CML Test Firewall endpoint");

app.Run();
