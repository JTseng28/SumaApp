using SumaModel;
using SumaBL;

namespace SumaUI
{
    public class AddUserMenu : IMenu
    {
        private ISumatraBL _sumaBL;
        public AddUserMenu(ISumatraBL p_sumaBL)
        {
            _sumaBL = p_sumaBL;
        }
        private static User _newUser = new User();
        public void Display()
        {
            System.Console.WriteLine("Enter new user information");
            System.Console.WriteLine("[1] - Username: " + _newUser.Username);
            System.Console.WriteLine("[2] - Password: " + _newUser.Password);
            System.Console.WriteLine("[3] - Name: " + _newUser.Name);
            System.Console.WriteLine("[4] - Email: " + _newUser.Email);
            System.Console.WriteLine("[5] - Save");
            System.Console.WriteLine("[0] - Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    System.Console.WriteLine("Enter Username");
                    _newUser.Username = Console.ReadLine();
                    return "AddUser";
                case "2":
                    System.Console.WriteLine("Enter a Password");
                    _newUser.Password = Console.ReadLine();
                    return "AddUser";
                case "3":
                    System.Console.WriteLine("Enter Name");
                    _newUser.Name = Console.ReadLine();
                    return "AddUser";
                case "4":
                    System.Console.WriteLine("Enter Email");
                    _newUser.Email = Console.ReadLine();
                    return "AddUser";
                case "5":
                
                    // try
                    // {   
                        Log.Information("Adding new user \n" + _newUser);
                        _sumaBL.AddUser(_newUser);
                        Log.Information("New user added");
                        System.Console.WriteLine("----------\nUser added successfully");
                        Console.ReadLine();
                    // }
                    // catch ()
                    // {

                    // }    
                  
                    return "MainMenu";

                default:
                    return "MainMenu";
                

            }
        }
    }
}