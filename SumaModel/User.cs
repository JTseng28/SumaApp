namespace SumaModel
{
    public class User
    {
        private string _username;
        private string _name;
        private string _password;
        private string _email;

        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public User()
        {
            Username = "jtseng11";
            Password = "password123";
            Name = "Jay";
            Email = "JT11@email.com";

        }
    }
}