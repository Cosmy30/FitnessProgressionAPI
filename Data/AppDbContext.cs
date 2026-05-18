using FitnessProgressionAPI.Enums;
using FitnessProgressionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessProgressionAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<ExerciseLog> ExerciseLogs { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Exercise>()
                .HasData(
                    new Exercise
                    {
                        Id = 1,
                        Name = "Pull-up",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Vertical Pull"
                    },

                    new Exercise
                    {
                        Id = 2,
                        Name = "Weighted Pull-up",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Advanced,
                        Family = "Vertical Pull"
                    },

                    new Exercise
                    {
                        Id = 3,
                        Name = "Pull-down",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Beginner,
                        Family = "Vertical Pull"
                    },

                    new Exercise
                    {
                        Id = 4,
                        Name = "Cable Row",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Beginner,
                        Family = "Horizontal Pull"
                    },

                    new Exercise
                    {
                        Id = 5,
                        Name = "Inverted Row",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Beginner,
                        Family = "Horizontal Pull"
                    },

                    new Exercise
                    {
                        Id = 6,
                        Name = "Barbell Row",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Horizontal Pull"
                    },

                    new Exercise
                    {
                        Id = 7,
                        Name = "Push-up",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Beginner,
                        Family = "Horizontal Push"
                    },

                    new Exercise
                    {
                        Id = 8,
                        Name = "Dip",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Horizontal Push"
                    },

                    new Exercise
                    {
                        Id = 9,
                        Name = "Bench Press",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Horizontal Push"
                    },

                    new Exercise
                    {
                        Id = 10,
                        Name = "Overhead Press",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Vertical Push"
                    },

                    new Exercise
                    {
                        Id = 11,
                        Name = "Pike Push-up",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Vertical Push"
                    },

                    new Exercise
                    {
                        Id = 12,
                        Name = "Handstand Push-up",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Advanced,
                        Family = "Vertical Push"
                    },

                    new Exercise
                    {
                        Id = 13,
                        Name = "Squat",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Beginner,
                        Family = "Squat"
                    },

                    new Exercise
                    {
                        Id = 14,
                        Name = "Weighted Squat",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Squat"
                    },

                    new Exercise
                    {
                        Id = 15,
                        Name = "Pistol Squat",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Advanced,
                        Family = "Squat"
                    },

                    new Exercise
                    {
                        Id = 16,
                        Name = "Deadlift",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Hinge"
                    },

                    new Exercise
                    {
                        Id = 17,
                        Name = "Leg Raise",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Core Flexion"
                    },

                    new Exercise
                    {
                        Id = 18,
                        Name = "Dragon Flag",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Advanced,
                        Family = "Core Static Hold"
                    },

                    new Exercise
                    {
                        Id = 19,
                        Name = "L-Sit",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Core Static Hold"
                    },

                    new Exercise
                    {
                        Id = 20,
                        Name = "Weighted Cable Crunch",
                        Category = ExerciseCategory.Weightlifting,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Core Flexion"
                    },

                    new Exercise
                    {
                        Id = 21,
                        Name = "Russian Twist",
                        Category = ExerciseCategory.Calisthenics,
                        DifficultyLevel = DifficultyLevel.Intermediate,
                        Family = "Core Rotation"
                    }
                );
        }

    }
}
