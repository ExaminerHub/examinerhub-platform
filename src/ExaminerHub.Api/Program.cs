using ExaminerHub.Application.Interfaces;
using ExaminerHub.Infrastructure.Repositories;
using ExaminerHub.Application.Services;
using ExaminerHub.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<SessionService>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();

builder.Services.AddDbContext<ExaminerHubDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ExaminerHubDatabase")));

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
