public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public DateTime DateOfBirth { get; set; }
    public decimal Weight { get; set; }
    public List<Workout> Workouts { get; set; } = new List<Workout>();
}