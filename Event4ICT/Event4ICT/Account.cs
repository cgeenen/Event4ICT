using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event4ICT
{
    class Account
    {
        public static int AccountID { get; set; }
        public static string AccountType { get; set; }
        public static string EmailAddress { get; set; }
        public static string VisitorIDRFID { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string Surename { get; set; }
        public static string Address { get; set; }
        public static string Country { get; set; }
        public static string PhoneNumber { get; set; }
        public static string BankAccount { get; set; }

        public Account(int AccountID, string AccountType, string EmailAddress,string VisitorIDRFID, string Password,string FirstName, string Surename, string Address,string Country, string PhoneNumber, string BankAccount)
        {
            Account.AccountID= AccountID;
            Account.AccountType = AccountType;
            Account.EmailAddress = EmailAddress;
            Account.VisitorIDRFID = VisitorIDRFID;
            Account.Password = Password;
            Account.FirstName = FirstName;
            Account.Surename = Surename;
            Account.Address = Address;
            Account.Country = Country;
            Account.PhoneNumber = PhoneNumber;
            Account.BankAccount = BankAccount;
        }
    }
}
