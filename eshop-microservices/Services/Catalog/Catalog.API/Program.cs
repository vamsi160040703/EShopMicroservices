var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
//Add services to the container

var app = builder.Build();


//Configure teh HTTp request pipeline
app.MapCarter();
app.Run();
