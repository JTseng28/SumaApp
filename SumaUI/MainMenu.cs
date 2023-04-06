namespace SumaUI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {

            System.Console.WriteLine("Welcome to Suma Cafe!\nWhat can I get for you today?");
            System.Console.WriteLine("[1] - Register New User");
            System.Console.WriteLine("[0] - Exit");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    return "AddUser";
                case "0":
                    return "Exit";
                default:
                    System.Console.WriteLine("Please input a valid response");
                    System.Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}