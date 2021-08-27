using System;
using System.Data;
using System.Data.SqlClient;
namespace ClassLibrary1
{
    public class DBconnect
    {
        private SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }
        private string _strConnect, _strServerName, _strDBName, _strUser, _strPassword;

        public string StrPassword
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }

        public string StrUser
        {
            get { return _strUser; }
            set { _strUser = value; }
        }

        public string StrDBName
        {
            get { return _strDBName; }
            set { _strDBName = value; }
        }

        public string StrServerName
        {
            get { return _strServerName; }
            set { _strServerName = value; }
        }

        public string StrConnect
        {
            get { return _strConnect; }
            set { _strConnect = value; }
        }
        public DBconnect()
        {

            StrServerName = @"DESKTOP-GAJACTU\SQLEXPRESS";
            StrDBName = "QLSACH_BANSACH";
            StrUser = "sa";
            StrPassword = "taquangtrung";
            StrConnect = "Data Source=" + StrServerName + "; Initial Catalog=" + StrDBName + "; User ID=" + StrUser + "; Password=" + StrPassword;
            Conn = new SqlConnection(StrConnect);
        }
        public DBconnect(string strconnect, string strservername, string strdbname, string struser, string strpassword)
        {
            StrConnect = strconnect;
            StrServerName = strservername;
            StrDBName = strdbname;
            StrUser = struser;
            StrPassword = strpassword;
            StrConnect = "Data Source=" + StrServerName + "; Initial Catalog=" + StrDBName + "; User ID=" + StrUser + "; Password=" + StrPassword;
            Conn = new SqlConnection(StrConnect);
        }
        public void openConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }
        public void closeConnection()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
        public void updateDatabase(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        private SqlDataAdapter danhsach;

        public SqlDataAdapter Danhsach
        {
            get { return danhsach; }
            set { danhsach = value; }
        }
        public void truyvanDL(string strSQL)
        {
            openConnection();
            danhsach = new SqlDataAdapter(strSQL, Conn);

            closeConnection();
        }
        public void loadCBO(String strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(strSQL, Conn);
            danhsach = new SqlDataAdapter(cmd);
            closeConnection();
        }

        public int getCount(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }
        public bool KiemTraTrung(string strSQL)
        {
            return getCount(strSQL) > 0 ? true : false;
        }
        public SqlDataReader getDataReader(String strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            SqlDataReader data = cmd.ExecuteReader();

            return data;

        }
    }
}
