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
    

}
