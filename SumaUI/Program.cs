using SumaModel;
using SumaUI;
using SumaBL;
using SumaDL;

bool repeat =  true;
IMenu menu = new MainMenu(); //As the other menus are derived from IMenu any class specific methods will be ignored

while (repeat)
{
    Console.Clear();
    menu.Display();

    string ans = menu.UserChoice();

    switch (ans)
    {
        case "AddUser":
            menu = new AddUserMenu(new SumatraBL(new Repository()));
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            System.Console.WriteLine("Page does not exist"); //this is for the dev
            break;
    }

}
