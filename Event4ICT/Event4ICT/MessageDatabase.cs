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
    class MessageDatabase : Database
    {

        
        public void SaveMessageToDatabase(DateTime messageNumber, int order,string message)
        {
            try
            {
                OpenConnection();
                Query = "INSERT INTO ACCOUNT (MESSAGENUMBER, ORDER, MESSAGE) VALUES (" + messageNumber + ", '" + order + ", '" + message +  "')";

                Command.Parameters.Add(new OracleParameter("MESSAGENUMBER", ));
                Command.Parameters.Add(new OracleParameter("ORDER", ));
                Command.Parameters.Add(new OracleParameter("MESSAGE", ));

                Command.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void SaveToDatabase(DateTime messageNumber, int order, string message, string filePath, int fileType, int report, int like, int dislike)
        {

        }
    }
}
