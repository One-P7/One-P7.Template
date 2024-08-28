using ThreeLayer.Database.AdventureWorks.DependencyInjection;
using ThreeLayer.Repository.DependencyInjection;
using ThreeLayer.Service.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// 註冊 Controller
builder.Services.AddControllers();

// 註冊 Service
builder.Services.AddService();

// 註冊 Repository
builder.Services.AddRepository();

// 註冊 Adventure Works EFCore
builder.Services.AddAdventureWorksDbContext(builder.Configuration);

// 註冊 Swagger
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();