using System;
using System.Linq;
using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using DependencyResolver;
using Ninject;

namespace ConsolePL
{
    class Program
    {
        private static readonly IKernel resolver;

        static Program()
        {
            resolver = new StandardKernel();
            resolver.ConfigurateResolver();
        }

        static void Main(string[] args)
        {
            IAccountService service = resolver.Get<IAccountService>();
            //IAccountNumberCreateService creator = resolver.Get<IAccountNumberCreateService>();
         
            service.OpenAccount("Account owner 1", BankAccountDTO.AccountTypeGradation.Base, 1);
            service.OpenAccount("Account owner 2", BankAccountDTO.AccountTypeGradation.Base, 2);
            service.OpenAccount("Account owner 3", BankAccountDTO.AccountTypeGradation.Gold, 3);
            service.OpenAccount("Account owner 4", BankAccountDTO.AccountTypeGradation.Base, 4);

            var creditNumbers = service.GetAllAccounts().Select(acc => acc.AccountNumber).ToArray();

            foreach (var t in creditNumbers)
            {
                service.DepositAccount(t, 100);
            }

            foreach (var item in service.GetAllAccounts())
            {
                Console.WriteLine(item);
            }

            foreach (var t in creditNumbers)
            {
                service.WithdrawAccount(t, 10);
            }

            foreach (var item in service.GetAllAccounts())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
