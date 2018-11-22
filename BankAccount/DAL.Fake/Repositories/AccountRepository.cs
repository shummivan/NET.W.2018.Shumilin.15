using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Interfaces;

namespace DAL.Fake.Repositories
{
    /// <summary>
    /// Simple class to work with repository
    /// </summary>
    public class AccountRepository : IRepository<BankAccount>
    {
        /// <summary>
        /// Account store
        /// </summary>
        private List<BankAccount> accountStore;

        /// <summary>
        /// Constructor
        /// </summary>
        public AccountRepository()
        {
            accountStore = new List<BankAccount>();
        }

        /// <summary>
        /// Add account
        /// </summary>
        /// <param name="acc">acc</param>
        public void AddAccount(BankAccount acc)
        {
            if (acc == null)
            {
                throw new ArgumentNullException();
            }
            accountStore.Add(acc);
        }

        /// <summary>
        /// Get account
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>account</returns>
        public BankAccount GetAccount(int id)
        {
            return accountStore.First(ba => ba.AccountNumber == id);
        }

        /// <summary>
        /// Remove account
        /// </summary>
        /// <param name="id">id</param>
        public void RemoveAccount(int id)
        {
            BankAccount acc = GetAccount(id);

            if (acc != null)
            {
                accountStore.Remove(acc);
            }
        }

        /// <summary>
        /// Find account
        /// </summary>
        /// <param name="predicate">Predicate</param>
        /// <returns>IEnumerable</returns>
        public IEnumerable<BankAccount> Find(Func<BankAccount, bool> predicate)
        {
            return accountStore.Where(predicate);
        }

        /// <summary>
        /// Get all accounts
        /// </summary>
        /// <returns>IEnumerable</returns>
        public IEnumerable<BankAccount> GetAll()
        {
            return accountStore;
        }
    }
}
