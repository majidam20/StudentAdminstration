using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


public class CreateCertification : StudentAdministration
{
    DAL DA = new DAL();

    public void Add( )
    {
        string Sql = @"INSERT INTO Schedule (StudentID, CourseID, Score)";
                      values ({0},{1},{2}");

        global g = new global();

        Sql = string.Format(Sql, StudentID, CourseID, Score );
        Connect&Disconnect(Sql);
    }

     
  
    public void Edit(int StudentID,int CourseID,float Score )
    {
        string sql = @"UPDATE Album SET  Score={0}  where StudentID={1} and CourseID={2}";

        sql = string.Format(sql,Score, StudentID, CourseID );

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
