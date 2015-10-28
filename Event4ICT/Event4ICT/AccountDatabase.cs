using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.Windows.Forms; 

namespace Event4ICT
{
    class AccountDatabase
    {
        Database database = new Database();

        public void SaveToDatabase(int AccountID, string AccountType, string EmailAddress, string VisitorIDRFID, string Password,string Firstname, string Surname, string Address, string Country, string PhoneNumber, string BankAccount)
        {
            try
            {
                database.OpenConnection();
                database.Query = "INSERT INTO ACCOUNT (ACCOUNTID, ACCOUNTTYPE, EMAILADDRESS, VISITORIDRFID, PASSWORD, FIRSTNAME, SURENAME, ADDRESS, COUNTRY, PHONENUMBER, BANKACCOUNT) VALUES (" + AccountID + ", '" + AccountType + ", '" + EmailAddress + ", '" + VisitorIDRFID + ", '" + Password + ", '" + Firstname + ", '" + Surname + ", '" + Address + ", '" + Country + ", '" + PhoneNumber + ", '" + BankAccount + "')";
                                                                                                                 
                database.Command.Parameters.Add(new OracleParameter("ACCOUNTID", Account.AccountID));
                database.Command.Parameters.Add(new OracleParameter("ACCOUNTTYPE", Account.AccountType));
                database.Command.Parameters.Add(new OracleParameter("EMAILADDRESS", Account.EmailAddress));
                database.Command.Parameters.Add(new OracleParameter("VISITORIDRFID", Account.VisitorIDRFID));
                database.Command.Parameters.Add(new OracleParameter("PASSWORD", Account.Password));
                database.Command.Parameters.Add(new OracleParameter("FIRSTNAME", Account.FirstName));
                database.Command.Parameters.Add(new OracleParameter("SURENAME", Account.Surename));
                database.Command.Parameters.Add(new OracleParameter("ADDRESS", Account.Address));
                database.Command.Parameters.Add(new OracleParameter("COUNTRY", Account.Country));
                database.Command.Parameters.Add(new OracleParameter("PHONENUMBER", Account.PhoneNumber));
                database.Command.Parameters.Add(new OracleParameter("BANKACCOUNT", Account.BankAccount));

                database.Command.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                database.CloseConnection();
            }
        }

    }
}
