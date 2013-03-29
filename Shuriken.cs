using System;

namespace SamuraiNinject
{
    internal class Shuriken : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pierced {0}'s armor", target);
        }
    }
}
