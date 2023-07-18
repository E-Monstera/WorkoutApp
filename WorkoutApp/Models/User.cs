namespace WorkoutApp.Models
{
    public class User
    {
        public User(string userName)
        {
            UserID = -1;
            UserName = userName;
        }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
