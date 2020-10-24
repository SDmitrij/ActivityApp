using ActivityApp.Shared.Interface;
using ActivityApp.User.Base.Interface;

namespace ActivityApp.User.Concrete
{
    public class NonHwol : IUser, INonHwolAble
    {
        public string Display()
        {
            return "I am a user with an unhealthy lifestyle!\n";
        }
    }
}
