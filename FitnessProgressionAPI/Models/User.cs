using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = "";

    [MaxLength(100)]
    public string Email { get; set; } = "";

    [MaxLength(100)]
    public string PasswordHash { get; set; } = "";

    public DateTime DateOfBirth { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal Weight { get; set; }

    public List<Workout> Workouts { get; set; } = new List<Workout>();
}