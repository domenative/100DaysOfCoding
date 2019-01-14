using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
using Ninject;
using _100DaysOfCoding.Packages.Models;

namespace _100DaysOfCoding.Packages.Helper
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MailSender>();
        }
    }
}
