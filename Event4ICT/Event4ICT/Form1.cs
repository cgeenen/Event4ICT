using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace Event4ICT
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*database.Query = "SELECT * FROM antwoord ORDER BY antwoordid";
            database.OpenConnection();


            OracleDataReader reader = database.Command.ExecuteReader();

            List<Account> account = new List<Account>();
            while (reader.Read())
            {
                account.Add(new Account(Convert.ToInt32(reader["AccountID"]), Convert.ToString(reader["AccountType"]), Convert.ToString(reader["EmailAddress"]), Convert.ToString(reader["VisitorIDRFID"]), Convert.ToString(reader["Password"]), Convert.ToString(reader["FirstName"]), Convert.ToString(reader["Surename"]), Convert.ToString(reader["Address"]), Convert.ToString(reader["Country"]), Convert.ToString(reader["PhoneNumber"]), Convert.ToString(reader["BankAccount"])));
            }

            foreach (Account item in account)
            {
                label1.Text = item.FirstName;
            }
            Refresh();
            database.CloseConnection();*/
            
            /*try
            {
                database.Command.ExecuteNonQuery();
                database.Success = true;
            }
            catch (OracleException)
            {
                database.Success = false; 
                throw;
            }
            MessageBox.Show(database.Success.ToString());
            database.CloseConnection();*/
                  
 

            /*database.Command.CommandText = "SELECT * FROM ACCOUNT WHERE AccountID = 1";
            database.OpenConnection();
            database.Command.CommandType = CommandType.Text;
            OracleDataReader reader = database.Command.ExecuteReader();
            List<Account> accounts = new List<Account>();
            while (reader.Read())
            {
                accounts.Add(new Account(Convert.ToInt32(reader["AccountID"]), Convert.ToString(reader["AccountType"]), Convert.ToString(reader["EmailAddress"]), Convert.ToString(reader["VisitorIDRFID"]), Convert.ToString(reader["Password"]), Convert.ToString(reader["FirstName"]), Convert.ToString(reader["Surename"]), Convert.ToString(reader["Address"]), Convert.ToString(reader["Country"]), Convert.ToString(reader["PhoneNumber"]), Convert.ToString(reader["BankAccount"])));
            }
            foreach (Account item in accounts)
            {
                label1.Text = item.ToString();
                Refresh();
            }
            database.CloseConnection();*/


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
