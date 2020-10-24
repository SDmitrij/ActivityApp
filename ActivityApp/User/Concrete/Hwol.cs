using ActivityApp.Shared.Interface;
using ActivityApp.User.Base.Interface;

namespace ActivityApp.User.Concrete
{
    public class Hwol : IUser, IHwolAble
    {      
        public string Display()
        {
            return "I am a user with a healthy lifestyle!\n";
        }
    }
}
