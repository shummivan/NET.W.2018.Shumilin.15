using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;

namespace BLL.Interface.Interfaces
{
    public interface IAccountService
    {
        void DepositAccount(int id, decimal money);
        void WithdrawAccount(int id, decimal money);
        IEnumerable<BankAccountDTO> GetAllAccounts();
        void OpenAccount(string v, BankAccountDTO.AccountTypeGradation @base, int id);
    }
}
