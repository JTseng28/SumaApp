using SumaModel;
using SumaBL;

namespace SumaUI
{
    class SearchUserMenu : IMenu
    {
        private ISumatraBL _sumaBL;
        public SearchUserMenu(ISumatraBL p_sumaBL)
        {
            _sumaBL = p_sumaBL;
        }
        public void Display()
        {
            System.Console.WriteLine("Search User by");
            System.Console.WriteLine("[1] - username");
            System.Console.WriteLine("[2] - email");
            System.Console.WriteLine("[0] - Go Back");
        }

        public string UserChoice()
        {
            string UserInput = Console.ReadLine();
            switch(UserInput)
            {
                case "1":

                    System.Console.WriteLine("Enter name");
                    string name = Console.ReadLine();

                    List<User> listOfUsers = _sumaBL.SearchUser(name);
                    Log.Information($"User looked up user by email({name})");

                    System.Console.WriteLine("=====================");


                    foreach(var item in listOfUsers)
                    {
                        Console.WriteLine(item);
                        System.Console.WriteLine("- - - - - - - - - - -");
                    }
                    
                    System.Console.WriteLine("Press enter to go back");
                    Console.ReadLine();
                    
                    return "MainMenu";

                case "2":

                    System.Console.WriteLine("Enter email");

                    string email = Console.ReadLine();
                    Log.Information($"User looked up user by email({email})");

                    List<User> listOfUsers2 = _sumaBL.SearchUserbyEmail(email);

                    System.Console.WriteLine("=====================");

                    foreach( var item in listOfUsers2)
                    {
                        Console.WriteLine(item);
                        System.Console.WriteLine("- - - - - - - - - - -");
                    }

                    System.Console.WriteLine("Press enter to go back");
                    Console.ReadLine();

                    return "MainMenu";

                case "0":

                    return "MainMenu";
                    
                default:

                    System.Console.WriteLine("Please input a valid Response");
                    System.Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();

                    return "SearchUser";
            }
        }
    }
}