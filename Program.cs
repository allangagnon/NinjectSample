using System;
using Ninject;
using Ninject.Modules;

namespace SamuraiNinject
{
    internal class Program
    {
        private static void Main()
        {
            //To use the Sword
            KernelBase kernel = new StandardKernel(new SwordModule());
            
            //To use the Shuriken
            //KernelBase kernel = new StandardKernel(new ShurikenModule());

            var sam = kernel.Get<IWarrior>();
            sam.Attack("the evildoers");
            Console.ReadKey();
        }
    }

    internal class SwordModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWarrior>().To<Samurai>();
            Bind<IWeapon>().To<Sword>();
        }
    }

    internal class ShurikenModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWarrior>().To<Samurai>();
            Bind<IWeapon>().To<Shuriken>();
        }
    }
}
