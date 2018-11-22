using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    /// <summary>
    /// Simple bank account class
    /// </summary>
    public class BankAccountDTO
    {
        /// <summary>
        /// Account number
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Bonus points
        /// </summary>
        public int Bonus { get; set; }

        /// <summary>
        /// Accont type
        /// </summary>
        public AccountTypeGradation AccountType { get; set; }

        /// <summary>
        /// Account status
        /// </summary>
        public AccountStatus Status { get; set; }

        /// <summary>
        /// Enum type
        /// </summary>
        public enum AccountTypeGradation
        {
            Base,
            Gold,
            Platinum
        }

        /// <summary>
        /// Enum status
        /// </summary>
        public enum AccountStatus
        {
            Active,
            Closed
        }
    }
}
