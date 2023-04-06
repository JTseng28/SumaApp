using SumaModel;
using SumaDL;

namespace SumaBL
{
    public class SumatraBL : ISumatraBL
    {
        private IRepository _repo;

        public SumatraBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public User AddUser(User p_user)
        {
            return _repo.AddUser(p_user);
        }

        public List<User> GetAllUsers()
        {

            return _repo.GetAllUsers();
        }

        public List<User> SearchUser(string p_name)
        {
            List<User> listOfUsers = _repo.GetAllUsers();

            return listOfUsers
                    .Where(x => x.Username.Contains(p_name)) //Where is designed to look through your list. The "Name" is from the class and Contains is a method in string class.
                    .ToList(); //tolist method converts the list collection that our method needs to return

           
        }

        public List<User> SearchUserbyEmail(string p_email)
        {
            List<User> listOfUsers = _repo.GetAllUsers();

            return listOfUsers
                    .Where(x => x.Email.Contains(p_email)) //Where is designed to look through your list. The "Name" is from the class and Contains is a method in string class.
                    .ToList(); //tolist method converts the list collection that our method needs to return


        }
    }

}