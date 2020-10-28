using ActivityApp.User;
using ActivityApp.User.Concrete;
using System;

namespace ActivityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = Creator.Create(typeof(SemiHwol).AssemblyQualifiedName);
            Console.WriteLine(user.Display());
        }
    }
}
