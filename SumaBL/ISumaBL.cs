using SumaModel;

namespace SumaBL;
/// <summary>
/// BL is responsible for manipulating the data obtained from the DB or the user
/// What kinda processing? All depends on the type of functionality you will be doing ( ex - randomizing the stats)
/// In charge of any special conditions
/// </summary>
public interface ISumatraBL
{
    
    User AddUser(User p_user);

    public List<User> GetAllUsers();

    /// <summary>
    /// Returns a list of user objects that are related to the searched name
    /// </summary>
    /// <param name="p_user">Name parameter being used to filter our Users</param>
    /// <returns></returns>
    List<User> SearchUser(string p_user);

    List<User> SearchUserbyEmail(string p_email);

}
