using SumaModel;

namespace SumaDL
{
    /// <summary>
    /// DL is responsible for interacting with the DB and doing strictly CRUD operations
    /// C: Create R: Read U: Update D: Delete
    /// It must NOT have logical operations that will also manipulate the data it is grabbing. That is the BL's job.
    /// DL is similar to a delivery person.
    /// </summary>
    public interface IRepository
    {
     
    /// <summary>
    /// Adds a new User to the database
    /// </summary>
    /// <param name="p_user"></param>
    /// <returns>Returns the User object that was added</returns>
        User AddUser(User p_user);

    /// <summary>
    /// Will give all pokemon in the databse. If its something which will be used multiple times, create a separate method.
    /// </summary>
    /// <returns></returns>
        List<User> GetAllUsers();
    }


    
}