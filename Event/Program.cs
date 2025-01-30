using Event.Helper;
using Event.Models;
using Event.Models.EventModels;
using Event.Repository.Implementations;
using Event.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HrmDBContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("HrmDatabase"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("HrmDatabase"))));

builder.Services.AddDbContext<EventContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EventDatabase")));

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IOldHrmRepository, OldHrmRepository>();
builder.Services.AddScoped<ITokenManager, TokenManager>();
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
