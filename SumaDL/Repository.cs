using SumaModel;
using System.Text.Json;

namespace SumaDL
{
    public class Repository : IRepository
    {
        private string _filepath = "../SumaDL/Database/"; //Starting point is SumaUI aka program.cs, not from the DL
        private string _jsonString;
        public User AddUser(User p_user)
        {
            string path = _filepath + "Users.json";
            List<User> listOfUsers = GetAllUsers(); //Using a method prevents the json file from replacing itself everytime.
            listOfUsers.Add(p_user);

            _jsonString = JsonSerializer.Serialize(listOfUsers, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);
            
            return p_user;
        }

        public List<User> GetAllUsers()
        {   

            _jsonString = File.ReadAllText(_filepath + "Users.json"); //grabbing the JSON file and storing it into _jsonString string.

           return JsonSerializer.Deserialize<List<User>>(_jsonString); //Deserializing the string _jsonString and converting it to a List<Customer>.
        }

     
    }

}