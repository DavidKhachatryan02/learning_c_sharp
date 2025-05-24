namespace User_Task_5
{
    public class Profile
    {
        public string? Bio;

        public Profile(string? bio = null)
        {
            Bio = bio;
        }
    }
    public class User
    {
        public Profile? Profile;

        public User(Profile profile = null)
        {
            Profile = profile;
        }
    }
}