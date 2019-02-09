# StudentAdminstration
pet project of advanced software engineering

note: i have described points in some photo's file.

 1-ech of my functions do es not have side effects on other functions because each of them do separate task indivisually.

2- i puted each task in one clear function and it would be very simple and short size, this is one reason of functional programming:

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
	   
  3-simple and pure functions and calling some functions in another functions is another reason of functional programming:
  
   public void Edit(int StudentID,int CourseID,float Score )
    {
        string sql = @"UPDATE Album SET  Score={0}  where StudentID={1} and CourseID={2}";

        sql = string.Format(sql,Score, StudentID, CourseID );

         Connect&Disconnect(Sql);
    }

4-use use of higher order functions, i mean calling functions very simple and clear: 
    //just connect and disconnet to database
     public void Connect&Disconnect(string Sql)
	 {
		    DA.Connect();
        DA.DoCommand(Sql);
        DA.Disconnect();
	 }


5-Anonymous function assigned to a variable. Easy to pass around and invoke when needed.

const myVar = function(){console.log(‘Anonymous function here!’);}
myVar();

//Anonymous function as argument

setInterval(function(){console.log(new Date().getTime())}, 1000);
//Anonymous functions within a higher order function

function mealCall(meal){
   return function(message){
     return console.log(message + “ “ + meal + ‘!!’)
    }
 }
const announceDinner = mealCall(‘dinner’);
const announceLunch = mealCall(‘breakfast’);
announceDinner(‘hey!, come and get your’);
announceLunch(‘Rise and shine! time for’);


6-pure functions with implicit parameter definitions in function:

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
