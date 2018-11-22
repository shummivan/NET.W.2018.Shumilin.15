using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Interfaces;
using System.IO;
using DAL.Fake.Repositories;

namespace DAL.Repositories
{
    /// <summary>
    /// Simple class to work with data
    /// </summary>
    public class FileWorker : IFileWorker
    {
        /// <summary>
        /// Path
        /// </summary>
        private string path;

        /// <summary>
        /// Repository
        /// </summary>
        private AccountRepository rep;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paths">Paths</param>
        public FileWorker(string paths)
        {
            path = paths ?? throw new ArgumentNullException();
            if (!File.Exists(paths))
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Accounts
        /// </summary>
        public IRepository<BankAccount> Accounts
        {
            get
            {
                if (rep == null)
                {
                    rep = new AccountRepository();
                }

                return rep;
            }          
         
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <param name="acc">Acc</param>
        public void Save(List<BankAccount> acc)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Open)))
            {
                foreach (var item in acc)
                {
                    writer.Write(item.AccountNumber);
                    writer.Write(item.FirstName);
                    writer.Write(item.LastName);
                    writer.Write(item.Amount);
                    writer.Write(item.Bonus);
                    writer.Write((int)item.AccountType);
                    writer.Write((int)item.Status);
                }
            }
        }
    }
}
