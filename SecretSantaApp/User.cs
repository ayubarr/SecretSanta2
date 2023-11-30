namespace SecretSantaApp
{
    public class User
    {

        public int UserId { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
