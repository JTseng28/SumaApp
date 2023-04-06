namespace SumaUI
{
    //Interface is one of the best ways to implement abstraction
    //Every method is implicitly abstract meaning you dont have to write abstract keyword
    //Every method is public


    public interface IMenu
    {
        //Interfaces implement abstraction
        /// <summary>
        /// Will display the menu and user choices in the terminal
        /// </summary>
        void Display();

    
        /// <summary>
        /// Will record the user's choices and change/route your menu based on that choice
        /// </summary>
        /// <returns>Return the menu that will change your screen</returns>
        string UserChoice();


    }
    
}