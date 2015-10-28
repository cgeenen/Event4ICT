using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event4ICT
{
    class Account
    {
        public int AccountID { get; set; }
        public string AccountType { get; set; }
        public string EmailAddress { get; set; }
        public string VisitorIDRFID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Surename { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string BankAccount { get; set; }

        public Account(int AccountID, string AccountType, string EmailAddress,string VisitorIDRFID, string Password,string FirstName, string Surename, string Address,string Country, string PhoneNumber, string BankAccount)
        {
            this.AccountID = AccountID;
            this.AccountType = AccountType;
            this.EmailAddress = EmailAddress;
            this.VisitorIDRFID = VisitorIDRFID;
            this.Password = Password;
            this.FirstName = FirstName;
            this.Surename = Surename;
            this.Address = Address;
            this.Country = Country;
            this.PhoneNumber = PhoneNumber;
            this.BankAccount = BankAccount;
        }
    }
}
