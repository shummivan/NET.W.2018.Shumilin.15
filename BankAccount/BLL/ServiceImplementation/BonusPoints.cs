using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.ServiceImplementation
{
    public class BonusPoints
    {
        /// <summary>
        /// Calculate bonus points
        /// </summary>
        /// <param name="accountGradation">Account gradation</param>
        /// <param name="amount">Amount</param>
        /// <returns>Bonus points</returns>
        public static int GetBonusPoints(BankAccount.AccountTypeGradation accountGradation, decimal amount)
        {
            switch (accountGradation)
            {
                case BankAccount.AccountTypeGradation.Base:
                    amount = amount / 100;
                    return (int)amount;
                case BankAccount.AccountTypeGradation.Gold:
                    amount = amount / 100 * 2;
                    return (int)amount;
                case BankAccount.AccountTypeGradation.Platinum:
                    amount = amount / 100 * 4;
                    return (int)amount;
            }
            return (int)amount;
        }
    }
}
