using ActivityApp.User.Base.Interface;
using System;

namespace ActivityApp.User.Base
{
    public class Creator
    {
        public static IUser Create(string userClassInfo)
        {         
            var userType = Type.GetType(userClassInfo);
            return Activator.CreateInstance(userType) as IUser;
        }
    }
}
