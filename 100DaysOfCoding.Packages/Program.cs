using _100DaysOfCoding.Packages.Helper;
using _100DaysOfCoding.Packages.Models;
using System;
using Ninject;
using System.Reflection;

namespace _100DaysOfCoding.Packages
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        static void Main(string[] args)
        {
        }

        private static void WithNinject()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IMailSender mailSender = kernel.Get<IMailSender>();

            FormHandler formHandler = new FormHandler(mailSender);
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }

        private static void WithoutNinject()
        {
            IMailSender mailSender = new MockMailSender();
            FormHandler formHandler = new FormHandler(mailSender);
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }



    }
}
