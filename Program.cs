using MySqlConnector;
using System.Security.Cryptography.X509Certificates;
namespace Lab9Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Check path
            Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName);

            ////Build Cxn
            //MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            //{
            //    Server = "localhost", //Enter Hostname, probably localhost
            //    UserID = "root", //Probably "root"
            //    Password = "password", //Enter you password
            //    Database = "Lab9DB" //Enter database name, probably "studentdatabase"
            //};

            Console.WriteLine("***** USING SQLITE *****");
            CourseManagerSQLite sqLiteDB = new CourseManagerSQLite();

            //Add new course
            Course webDev = new Course (1001, "web dev for n00bz", 1);
            Course fullStack = new Course(1002, "Introduction to Full Stack Programming", 3);
            Course database = new Course(1003, "Databases", 3);
            Course softDA = new Course(1004, "Principles of Software Design and Analysis", 4);
            Course objectOP = new Course(1005, "Object-Oriented Programming", 4);
            Course basket = new Course(1006, "Underwater Basket Weaving", 1);


            sqLiteDB.AddCourse(webDev);
            sqLiteDB.AddCourse(fullStack);
            sqLiteDB.AddCourse(database);
            sqLiteDB.AddCourse(softDA);
            sqLiteDB.AddCourse(objectOP);

            //Read course
            Console.WriteLine($"\n{sqLiteDB.GetCourseByID(1001)}");

            //Update course
            Course updatedCourse = sqLiteDB.GetCourseByID(1001);
            updatedCourse.Name = "Fundamentals of Web Development";
            updatedCourse.Credits = 3;
            sqLiteDB.UpdateCourse(updatedCourse);

            //Delete
            sqLiteDB.DeleteCourse(1006);

            //Show all courses
            Console.WriteLine("\nSHOWING ALL COURSES:");
            List<Course> CourseSqlite = sqLiteDB.GetAllCourses();
            foreach (var c in CourseSqlite)
            {
                Console.WriteLine(c);
            }

            //Delete all courses
            //Console.WriteLine("\nDELETING ALL COURSES");
            //List<Course> DumpSqlite = sqLiteDB.GetAllCourses();
            //if (DumpSqlite.Count > 0)
            //{
            //    int i = DumpSqlite[0].CourseId;
            //    foreach (var c in DumpSqlite)
            //    {
            //        sqLiteDB.DeleteCourse(i); i++;
            //    }
            //}
            //Console.WriteLine("\nCOURSES NOT DELETED:");
            //List<Course> ClearSqlite = sqLiteDB.GetAllCourses();
            //foreach (var c in ClearSqlite)
            //{
            //    Console.WriteLine(c);
            //}
        }
    }
}
