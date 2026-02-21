using challengeApp.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();


app.Run();

