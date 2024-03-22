using Employee_Management_System.Models;
using Employee_Management_System.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);


builder.Services.Configure<EmsDatabaseSetting>(
    builder.Configuration.GetSection(nameof(EmsDatabaseSetting)));


builder.Services.AddSingleton<IEmsDatabaseSetting>(
    sp => sp.GetRequiredService<IOptions<EmsDatabaseSetting>>().Value);

builder.Services.AddSingleton<IMongoClient>(
    s => new MongoClient(builder.Configuration.GetValue<string>("EmsDatabaseSetting:ConnectionString")));


builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corspolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
