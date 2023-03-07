using Microsoft.EntityFrameworkCore;
using Thirtysix_app.Database;
using Thirtysix_app.WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IBicikliService, BicikliService>();
var connectionString = builder.Configuration.GetConnectionString("Konekcija");
builder.Services.AddDbContext<eBicikliContext>(o => o.UseSqlServer(connectionString));
builder.Services.AddAutoMapper(typeof(IBicikliService));
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
