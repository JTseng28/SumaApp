global using Serilog; //global saves from importing the namespace on all files
using SumaModel;
using SumaUI;
using SumaBL;
using SumaDL;


Log.Logger = new LoggerConfiguration().WriteTo.File("./logs/user.txt").CreateLogger(); //creating and configuring our logger

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
            Log.Information("Displaying Add User Menu");
            menu = new AddUserMenu(new SumatraBL(new Repository()));
            break;
        case "SearchUser":
            Log.Information("Displaying Search User Menu");
            menu = new SearchUserMenu(new SumatraBL(new Repository()));
            break;
        case "UserList":
            Log.Information("Displaying Users Menu");
            menu = new GetUsersMenu(new SumatraBL(new Repository()));
            break;
        case "MainMenu":
            Log.Information("Displaying Main Menu");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Information("Exiting Application");
            Log.CloseAndFlush(); //To close logger resource. External packages needs to exited manually.
            repeat = false;
            break;
        default:
            System.Console.WriteLine("Page does not exist"); //this is for the dev
            System.Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            break;
    }

}
