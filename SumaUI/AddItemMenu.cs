using SumaModel;

namespace SumaUI
{
    public class AddItemMenu : IMenu
    {
        private static Drink _newDrink = new Drink();
        public void Display()
        {
            System.Console.WriteLine("Enter Info");
            System.Console.WriteLine("1 - Name: " + _newDrink.Name);
            System.Console.WriteLine("2 - Price: " + _newDrink.Price);
            System.Console.WriteLine("3 - Hot or Cold: " + _newDrink.Temp);
            System.Console.WriteLine("4 - Save");
            System.Console.WriteLine("0 - Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Enter the Drink Name.");
                    _newDrink.Name = Console.ReadLine();
                    return "AddItem";
                case "2":
                    return "";
                case "3":
                    return "";
                case "4":
                    return "";
                case "0":
                    return "";
                default:
                    return "MainMenu";

            }
        }
    }

}