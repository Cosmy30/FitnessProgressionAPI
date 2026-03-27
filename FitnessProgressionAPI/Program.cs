using Microsoft.EntityFrameworkCore;
using FitnessProgressionAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options => 
        options.SwaggerDoc("v1", new()
        {
            Title = "FitnessProgressionAPI",
            Version = "v1",
            Description = "API for tracking workout progress"
        }));

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
