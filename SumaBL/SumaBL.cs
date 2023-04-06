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
    }

}