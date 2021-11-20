global using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "RMA CML Test Firewall endpoint");
app.MapGet("/todo", () => new Todo(Title: "Update Firewall", Body: "Update ISP firewall to allow CML to communicate with Azure backend"));


app.Run();
