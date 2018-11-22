using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;

namespace DAL.Interface.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetAccount(int id);
        void AddAccount(T acc);
        void RemoveAccount(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
    }
}
