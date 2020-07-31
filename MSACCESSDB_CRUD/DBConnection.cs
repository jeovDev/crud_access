using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace MSACCESSDB_CRUD
{
    //THIS CLASS HELP US TO CONNECT TO OUR DATABASE
    class DBConnection
    {
        public static OleDbConnection connection()
        {
            OleDbConnection Conn = new OleDbConnection();
            try
            {
                //Provider of your microsoft access version
                String strConn = "Provider=Microsoft.Ace.OlEDB.12.0; ";
                //Path where your database file is located
                strConn += "Data Source =" + Application.StartupPath + "\\CRUDAccess.accdb;"; 
                strConn += "Persist Security Info=False;";
                Conn.ConnectionString = strConn;
                Conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Connecting to Database." + ex.Message, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            return Conn;
        
        
        }
    }
}
