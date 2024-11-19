using DropOfMilkClinic.Core.IRespositories;
using DropOfMilkClinic.Core.IServices;
using DropOfMilkClinic.Data.Repositories;
using DropOfMilkClinic.Serivce.Services;
using DropOfMilkClinic.Serivce;
using DropOfMilkClinic.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBabyService, BabyService>();
builder.Services.AddScoped<IBabyRepository, BabyRepository>();

builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<IBranchRepository, BranchRepository>();

builder.Services.AddScoped<INurseService, NurseService>();
builder.Services.AddScoped<INurseRepository, NurseRepository>();

builder.Services.AddScoped<IRecommandationService, RecommendationService>();
builder.Services.AddScoped<IRecommendationRepository, RecommendationRepository>();

builder.Services.AddScoped<ITurnService, TurnService>();
builder.Services.AddScoped<ITurnRepository, TurnRepository>();

builder.Services.AddSingleton<DataContex>();


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
