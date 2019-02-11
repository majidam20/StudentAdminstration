using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

public class LDAL
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;

    public LDAL()
    {
        cmd = new SqlCommand();
        con = new SqlConnection();
        da = new SqlDataAdapter();
        cmd.Connection = con;
        da.SelectCommand = cmd;
    }
	
    public void Connect()
    {
        con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\LDB\\DB.mdf;Integrated Security=True;User Instance=True";
        if (con.State != ConnectionState.Open)
            con.Open();
    }
	
    public void Disconnect()
    {
        if (con.State == ConnectionState.Open)
            con.Close();
    }
	
	//recieve each aribitary sql query and execute that
    public DataTable Select(string sql)
    {
        DataTable dt = new DataTable();
        cmd.CommandText = sql;
        da.Fill(dt);
        return dt;
    }
	
    public void DoCommand(string sql)
    {
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }
}
