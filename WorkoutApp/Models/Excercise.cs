namespace WorkoutApp.Models
{
    public class Excercise
    {
        public Excercise(string name, bool isCustom)
        {
            ExcerciseID = -1;
            Name = name;
            IsCustom = isCustom;
        }
        public int ExcerciseID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? VideoLink { get; set; }
        public bool IsCustom { get; set; }
        public List<string>? Muscles { get; set; }
        public User? Creator { get; set; }
    }
}
