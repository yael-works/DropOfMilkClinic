using DropOfMilkClinic.Data.Repositories;
using DropOfMilkClinic.Serivce;
using DropOfMilkClinic.Data;
using DropOfMilkClinic.Core.Services;
using DropOfMilkClinic.Services;
using DropOfMilkClinic.Core.Respositories;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IBabyService, BabyService>();
builder.Services.AddScoped<IBabyRespository, BabyRepository>();


builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<IBranchRespository, BranchRepository>();

builder.Services.AddScoped<INurseService, NurseService>();
builder.Services.AddScoped<INurseRespository, NurseRepository>();


builder.Services.AddScoped<ITurnService, TurnService>();
builder.Services.AddScoped<ITurnRespository, TurnRepository>();

builder.Services.AddDbContext<DataContex>();


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
