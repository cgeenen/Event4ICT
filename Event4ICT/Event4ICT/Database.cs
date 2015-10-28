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
        public class Database
        {
            private string _connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=local;Password=Bethom22!";
            private OracleConnection _connection;
            private OracleCommand command;
            private bool success = false;

            public bool Success
            {
                get { return success; }
                set { success = value; }
            }

            /// <summary>
            /// Stel de SQL query in die uitgevoerd moet gaan worden.
            /// </summary>
            public string Query
            {
                set
                {
                    OpenConnection();
                    // Stel het SQL commando in met de gegeven query
                    command = new OracleCommand(value, _connection);
                }
            }

            /// <summary>
            /// Haalt het command-object op waarmee queries uitgevoerd kunnen worden.
            /// </summary>
            public OracleCommand Command
            {
                get { return command; }
            }

            /// <summary>
            /// Open de verbinding met de database
            /// </summary>
            public OracleConnection OpenConnection()
            {

                _connection = new OracleConnection(_connectionString);
                try
                {
                    // Controleer of de verbinding niet al open is
                        _connection.Open();
                        MessageBox.Show("Correct");
                }
                catch (OracleException)
                {
                    MessageBox.Show("fout");
                    throw;
                }
                return _connection;
            }

            /// <summary>
            /// Sluit de verbinding met de database
            /// </summary>
            public void CloseConnection()
            {
                // Controleer of de verbinding niet al gesloten is
                if (_connection.State != System.Data.ConnectionState.Closed)
                {
                    _connection.Close();
                }
            }
        }
    }

    

