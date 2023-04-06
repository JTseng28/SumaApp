using SumaModel;
using SumaBL;
using System.Collections;

namespace SumaUI
{
    class GetUsersMenu : IMenu
    {
        private ISumatraBL _sumaBL;


        public GetUsersMenu(ISumatraBL p_sumaBL)
        {
            _sumaBL = p_sumaBL;
        }
        public void Display()
        {
            System.Console.WriteLine("List of Users");
            System.Console.WriteLine("=====================");

            List<User> listOfUsers = _sumaBL.GetAllUsers();

            foreach(User user in listOfUsers)
            {
            System.Console.WriteLine(user);
            System.Console.WriteLine("- - - - - - - - - - -");
            }
            
            System.Console.WriteLine("[1] - Go back\n");
            
        }

        public string UserChoice()
        {
            string UserInput = Console.ReadLine();

            if(UserInput == "1")
            {
                return "MainMenu";
            }
            else
            {
                return "MainMenu";
            }
        }
    }
}