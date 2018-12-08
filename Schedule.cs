using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


public class Schedule : StudentAdministration
{
    DAL DA = new DAL();

    public void Add( )
    {
        string Sql = @"INSERT INTO Schedule (CourseID, ClassName, Teacher,Date,StudentID)";
                      
                      values ({0},'{1}','{2}',{3}");

        global g = new global();

        Sql = string.Format(Sql, CourseID, ClassName, Teacher,Date,StudentID);
        Connect&Disconnect(Sql);
    }

     
    public void Edit(int CourseID,string ClassName,string Teacher,string Date,int StudentID)
    {
        string sql = @"UPDATE Album SET  ClassName='{0}',Teacher='{1}',Date='{2}'  where CourseID={3} and StudentID={4}";

        sql = string.Format(sql,ClassName, Teacher, Date,CourseID,StudentID);

         Connect&Disconnect(Sql);
    }

    //just connect and disconnet to database
     public void Connect&Disconnect(string Sql)
	 {
		DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
	 }
 



}