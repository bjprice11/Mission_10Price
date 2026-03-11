using Microsoft.EntityFrameworkCore;
using Mission_10Price.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Add the database context to the container
builder.Services.AddDbContext<BowlingDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BowlingConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//Allow the frontend to access the API
app.UseCors(x => x.WithOrigins("http://localhost:4200"));

//Redirect to the HTTPS version of the site
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();