var builder = WebApplication.CreateBuilder(args);

//Add services to the container

var app = builder.Build();

//Configure teh HTTp request pipeline
Console.WriteLine("Hello World");
app.Run();
