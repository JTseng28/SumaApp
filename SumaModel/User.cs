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

        public override string ToString()//formatting of how ths User class will be displays in the console instead of the default "SumaModel.User". Method comes from System.Object. 
        {
            return $"Username: {Username}\nName: {Name}\nEmail: {Email}";
        }
    }
}