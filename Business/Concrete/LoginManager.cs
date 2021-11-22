using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class LoginManager /*: ILoginService*/
    {
        IUserDal _userDal;
        string _mail;
        string _password;
        public LoginManager(string mail, string password, IUserDal userdal)
        {
            _userDal = userdal;
            _mail = mail;
            _password = password;
        }

        public bool LoginAccess()
        {
            var user = _userDal.GetById(u => u.Mail == _mail && u.Password == _password);
            if (user == null)
            {
                return false;
            }

            return true;
        }

    }
}
