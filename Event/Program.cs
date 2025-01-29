
using BUECarSystem.Implementations.Repositories;
using BUECarSystem.Interfaces.Repositories;
using Event.Models;
using Event.Models.EventModels;
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
