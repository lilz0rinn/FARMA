using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace farma
{
    internal class Dbase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=tabletki;");

        public void openconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeconnection() 
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
/// <summary>
/// ///////////////////////////
/// </summary>
/// 


}


internal class accBase
     {

        
        MySqlConnection connection2 = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=accounts;");

        public void openconnection2()
        {
            if (connection2.State == System.Data.ConnectionState.Closed)
            {
                connection2.Open();
            }
        }
        public void closeconnection2()
        {
            if (connection2.State == System.Data.ConnectionState.Open)
            {
                connection2.Close();
            }
        }

        public MySqlConnection getConnection2()
        {
            return connection2;
        }
     }
    /// <summary>
    /// /////////////////////////////
    /// </summary>
    internal class adminBase
    {


        MySqlConnection connectionadmin = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=admins;");

        public void openconnectionadmin()
        {
            if (connectionadmin.State == System.Data.ConnectionState.Closed)
            {
                connectionadmin.Open();
            }
        }
        public void closeconnectionadmin()
        {
            if (connectionadmin.State == System.Data.ConnectionState.Open)
            {
                connectionadmin.Close();
            }
        }

        public MySqlConnection getConnectionadmin()
        {
            return connectionadmin;
        }
    }




}
