using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;

namespace DAL.Interface.Interfaces
{
    public interface IFileWorker
    {
        void Save(List<BankAccount> books);
        IRepository<BankAccount> Accounts { get; }
    }
}
