using ActivityApp.Shared.Interface;
using ActivityApp.User.Base.Interface;

namespace ActivityApp.User.Concrete
{
    public class SemiHwol : IUser, IHwolAble, INonHwolAble
    {
        public string Display()
        {
            return "I am a user with a mixed lifestyle!\n";
        }
    }
}
