using Microsoft.EntityFrameworkCore;
using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.Services.Interfaces;
using FitnessProgressionAPI.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(
        new System.Text.Json.Serialization.JsonStringEnumConverter());
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
        options.SwaggerDoc("v1", new()
        {
            Title = "FitnessProgressionAPI",
            Version = "v1",
            Description = "API for tracking workout progress"
        }));

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IWorkoutService, WorkoutService>();
builder.Services.AddScoped<IExerciseLogService, ExerciseLogService>();
builder.Services.AddScoped<IUserContext, FakeUserContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
