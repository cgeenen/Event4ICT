using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace Event4ICT
{
    class Fileshare
    {
        Database database = new Database();
        public void Upload(int FileID, string FileName, string FileType)
        {
            try
            {
                database.OpenConnection();
                database.Query = "INSERT INTO MFILE (FILEID, FILENAME, FILETYPE) VALUES (" + FileID + ", '" + FileName + ", '" + FileType + "')";

                database.Command.Parameters.Add(new OracleParameter("FILEID", Account.AccountID));
                database.Command.Parameters.Add(new OracleParameter("FILENAME", Account.AccountType));
                database.Command.Parameters.Add(new OracleParameter("FILETYPE", Account.EmailAddress));
          

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
