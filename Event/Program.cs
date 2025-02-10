using Event.Helper;
using Event.Models;
using Event.EventModel;
using Event.Repository.Implementations;
using Event.Repository.Interfaces;
using Event.Services.Implementations;
using Event.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Event.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HrmDBContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("HrmDatabase"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("HrmDatabase"))));

builder.Services.AddDbContext<EventContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EventDatabase")),
    ServiceLifetime.Scoped);

builder.Services.AddControllers();
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IOldHrmRepository, OldHrmRepository>();
builder.Services.AddScoped<ITokenManager, TokenManager>();
builder.Services.AddScoped<IMailService, MailService>();
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddJwtBearerAuthentication();


var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
             .AllowAnyHeader()
             .AllowAnyMethod()
             .SetIsOriginAllowed((host) => true)
             .AllowCredentials()
        );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
