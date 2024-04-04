using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Database
{
    internal class CourseManagerSQLite
    {
        private SQLiteConnection database;

        public CourseManagerSQLite()
        {
            //Instantiating the connection object with the db path via Constants class
            this.database = new SQLiteConnection(Constants.DatabasePath);
            //Create the Course database table
            this.database.CreateTable<Course>();
        }

        //Add a course
        public void AddCourse(Course c)
        {
            this.database.Insert(c);
            Console.WriteLine($"Added {c.Name}");
        }

        //Read (retrieve) Course by ID
        public Course GetCourseByID(int id)
        {
            return this.database.Table<Course>().Where(c  => c.CourseId == id).FirstOrDefault();
        }

        //Update Course
        public void UpdateCourse(Course c)
        {
            this.database.Update(c);
            Console.WriteLine($"{c.Name} updated");
            Console.WriteLine($"Course ID: {c.CourseId}\n" +
                $"Name:      {c.Name}\n" +
                $"Credit:    {c.Credits}");
        }

        //Delete Course
        public void DeleteCourse(int id)
        {
            this.database.Delete<Course>(id);
            Console.WriteLine($"\nCourse with ID {id} deleted");
        }

        //Display all Courses
        public List<Course> GetAllCourses()
        {
            return this.database.Table<Course>().ToList();
        }
    }
}
